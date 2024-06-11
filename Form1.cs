using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomat
{
    public partial class Bankomat : Form
    {
        public Bankomat()
        {
            InitializeComponent();
            BanknotyOdswiez();

            //wstawia kropki w miejsce liter
            loginTextBox.PasswordChar = '•';
            adminHasloTextBox.PasswordChar = '•';
        }

        bool trybAdmina = false;

        bool trybUzytkownika = false;

        private int[] indexBanknot = new int[6]; //index - od 0 do 5

        private int[] banknoty = { 500, 200, 100, 50, 20, 10 };

        public int[] liczbaBankt = { 20, 20, 20, 20, 20, 20 }; 
        
        private const int MaxUzycie = 3;


        private void BanknotyOdswiez()
        {
            banknotyListBox.Items.Clear();
            banknotyListBox.Items.Add($"Wartość: {banknoty[5]} zł - Ilość: {liczbaBankt[5]}");
            banknotyListBox.Items.Add($"Wartość: {banknoty[4]} zł - Ilość: {liczbaBankt[4]}");
            banknotyListBox.Items.Add($"Wartość: {banknoty[3]} zł - Ilość: {liczbaBankt[3]}");
            banknotyListBox.Items.Add($"Wartość: {banknoty[2]} zł - Ilość: {liczbaBankt[2]}");
            banknotyListBox.Items.Add($"Wartość: {banknoty[1]} zł - Ilość: {liczbaBankt[1]}");
            banknotyListBox.Items.Add($"Wartość: {banknoty[0]} zł - Ilość: {liczbaBankt[0]}");
            
        }

        private int ZnajdzGrupeMaksBankt(int remainingAmount)
        {
            int maxBanknotow = 0;
            int indexGrupy = -1;
            int iloscPieniedzy = 0;
            for (int i = 0; i < liczbaBankt.Length; i++)
            {
                iloscPieniedzy = iloscPieniedzy + liczbaBankt[i] * banknoty[i];
            }

            if (iloscPieniedzy < remainingAmount)
            {
                return indexGrupy;
            }

            for (int i = 0; i < liczbaBankt.Length; i++)
            {
                if (liczbaBankt[i] > maxBanknotow && banknoty[i] <= remainingAmount)
                {
                    maxBanknotow = liczbaBankt[i];
                    indexGrupy = i;
                    
                    if (indexGrupy == -1)
                    {
                        break;
                    }
                }
            }

            return indexGrupy;
        }

        private bool DostepnoscNominalow(int kwota)
        {
            int pozostalaKwota = kwota;
            for (int i = 0; i < banknoty.Length; i++)
            {
                while (pozostalaKwota >= banknoty[i] && liczbaBankt[i] > 0)
                {
                    pozostalaKwota -= banknoty[i];
                }
            }
            return pozostalaKwota == 0;
        }

        private void PobierzKwote(int kwota, int[] uzyteBankt)
        {
            int pozostalaKwota = kwota;

            while (pozostalaKwota > 0)
            {
                int indexGrupy = ZnajdzGrupeMaksBankt(pozostalaKwota);
                if (indexGrupy == -1)
                {
                    MessageBox.Show("Nie ma wystarczającej ilości banknotów do wypłaty.");
                    BanknotyOdswiez(); 
                    return;
                }

                int iloscDoPobrania = Math.Min(MaxUzycie, Math.Min(liczbaBankt[indexGrupy], pozostalaKwota / banknoty[indexGrupy]));
                int wartoscBanknotu = banknoty[indexGrupy];

                for (int i = 0; i < iloscDoPobrania; i++)
                {
                    pozostalaKwota -= wartoscBanknotu;
                    liczbaBankt[indexGrupy]--;
                    indexBanknot[indexGrupy]++;
                    uzyteBankt[indexGrupy]++;
                }
            }

            BanknotyOdswiez();
        }


        private void wstawBanknotyButton_Click(object sender, EventArgs e)
        {
            if (trybAdmina)
            {
                if (int.TryParse(wartoscBanknotuTextBox.Text, out int wartosc) && int.TryParse(ileBanknotowTextBox.Text, out int ilosc))
                {
                    if (ilosc >= 1) //sprawdzenie, czy ilość banknotów jest większa lub równa 1
                    {
                        if (banknoty.Contains(wartosc))
                        {
                            int index = Array.IndexOf(banknoty, wartosc);
                            liczbaBankt[index] += ilosc;
                            BanknotyOdswiez();
                            wartoscBanknotuTextBox.Clear();
                            ileBanknotowTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Niepoprawna wartość banknotu.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ilość banknotów musi być większa lub równa 1.");
                    }
                }
                else
                {
                    MessageBox.Show("Niepoprawne dane.");
                }
            }
            else
            {
                MessageBox.Show("Funkcja dostępna tylko dla administratora.");
            }
        }


        private void wyplacButton_Click(object sender, EventArgs e)
        {
            if (trybUzytkownika)
            {
                int kwota;
                if (!int.TryParse(kwotaTextBox.Text, out kwota) || kwota <= 0 || kwota % 10 != 0 || !DostepnoscNominalow(kwota))
                {
                    //MessageBox.Show("Błędna kwota do wypłaty.");
                    MessageBox.Show("Błędna kwota do wypłaty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                int[] uzyteBankt = new int[6];
                PobierzKwote(kwota, uzyteBankt);
                StringBuilder messageBuilder = new StringBuilder();
                messageBuilder.AppendLine("Wypłacone banknoty:");
                for (int i = 0; i < uzyteBankt.Length; i++)
                {
                    if (uzyteBankt[i] > 0)
                    {
                        messageBuilder.AppendLine($"Ilość: {uzyteBankt[i]} - Wartość: {banknoty[i]} zł");
                    }
                }

                wynikRichTextBox.Text = messageBuilder.ToString();
            }
            else
            {
                MessageBox.Show("Użytkownik nie jest zalogowany.");
            }
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            if (adminHasloTextBox.Text == "admin")
            {
                trybAdmina = true;
                adminHasloTextBox.Clear();
                MessageBox.Show("Zalogowano jako administrator.");
            }
            else
            {
                MessageBox.Show("Niepoprawne hasło administratora.");
            }
        }

        private void adminLogoutButton_Click(object sender, EventArgs e)
        {
            trybAdmina = false;
            MessageBox.Show("Wylogowano z trybu administratora.");
        }


        private void zalogujButton_Click(object sender, EventArgs e)
        {
            string haslo = loginTextBox.Text;
            if (loginTextBox.Text == haslo && loginTextBox.Text != "")
            {
                trybUzytkownika = true;
                loginTextBox.Clear();
                MessageBox.Show("Pomyślnie zalogowano użytkownika.", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Niepoprawne hasło użytkownika.");
            }
        }

        private void wylogujUserButton_Click(object sender, EventArgs e)
        {
            trybUzytkownika = false;
            MessageBox.Show("Użytkownik został wylogowany.");
        }

        private void KopiujButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(wynikRichTextBox.Text);
        }
        
    }
}


