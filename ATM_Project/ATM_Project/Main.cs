using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project
{
    public partial class Main : Form
    {
        private RSACryptoServiceProvider rsa;
        private String pub_key;
        private List<string> keyMatrix;
        private Button[,] btnList = new Button[5, 5];
        public Main()
        {
            InitializeComponent();
        }

        private void btn_GenKey_Click(object sender, EventArgs e)
        {
            try
            {
                rsa = new RSACryptoServiceProvider();

                tb_PrivateKey.Text = rsa.ToXmlString(true);
                tb_PublicKey.Text = rsa.ToXmlString(false);

                MessageBox.Show("Key pair generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] data = Encoding.UTF8.GetBytes(tb_Input.Text);
                byte[] encryptedData = EncryptData(data, tb_PublicKey.Text);
                tb_EncryptOutput.Text = Convert.ToBase64String(encryptedData);

                MessageBox.Show("Encrypted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string ciphertext = tb_Input.Text;
                byte[] data = Convert.FromBase64String(ciphertext);

                byte[] decryptedData = DecryptData(data, tb_PrivateKey.Text);
                tb_DecryptOutput.Text = Encoding.UTF8.GetString(decryptedData);
                MessageBox.Show("Decrypted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Byte[] EncryptData(byte[] data, String public_key)
        {
            using (RSACryptoServiceProvider rsaEncryptor = new RSACryptoServiceProvider())
            {
                Console.WriteLine(public_key);
                rsaEncryptor.FromXmlString(public_key);
                return rsaEncryptor.Encrypt(data, false);
            }
        }

        private Byte[] DecryptData(byte[] data, String private_key)
        {
            using (RSACryptoServiceProvider RSADecryptor = new RSACryptoServiceProvider()) 
            {
                RSADecryptor.FromXmlString(private_key);
                return rsa.Decrypt(data, false);
            }
        }

        private void btn_PF_Encrypt_Click(object sender, EventArgs e)
        {
            string key = tb_PF_Key.Text;
            string plainText = tb_PF_Input.Text;

            // Calling the key generation function
            keyMatrix = KeyGeneration(key);
            PrintMatrix(keyMatrix);
            DisplayMatrix(keyMatrix);

            // Calling the conversion function
            Encryption(plainText);
        }

        private void btn_PF_Decrypt_Click(object sender, EventArgs e)
        {
            string key = tb_PF_Key.Text;
            string cipherText = tb_PF_Input.Text;

            // Calling the key generation function
            keyMatrix = KeyGeneration(key);
            Console.WriteLine("Key Matrix for decryption:");
            PrintMatrix(keyMatrix);
            DisplayMatrix(keyMatrix);
            // Calling the conversion function
            Decryption(cipherText);
        }
        private List<string> KeyGeneration(string key)
        {
            string main = "abcdefghijklmnopqrstuvwxyz".Replace('j', '.');

            key = key.ToLower();

            List<string> keyMatrix = Enumerable.Range(0, 5).Select(_ => "").ToList();
            int i = 0, j = 0;

            foreach (char c in key)
            {
                if (main.Contains(c))
                {
                    keyMatrix[i] += c;
                    main = main.Replace(c, '.');
                    j++;

                    if (j > 4)
                    {
                        i++;
                        j = 0;
                    }
                }
            }

            foreach (char c in main)
            {
                if (c != '.')
                {
                    keyMatrix[i] += c;
                    j++;

                    if (j > 4)
                    {
                        i++;
                        j = 0;
                    }
                }
            }

            return keyMatrix;
        }

        private void Encryption(string plainText)
        {
            List<string> plainTextPairs = new List<string>();
            List<string> cipherTextPairs = new List<string>();

            plainText = plainText.Replace(" ", "").ToLower();

            int i = 0;

            while (i < plainText.Length)
            {
                char a = plainText[i];
                char b = (i + 1) == plainText.Length ? 'x' : plainText[i + 1];

                if (a != b)
                {
                    plainTextPairs.Add($"{a}{b}");
                    i += 2;
                }
                else
                {
                    plainTextPairs.Add($"{a}x");
                    i++;
                }
            }

            Console.WriteLine("Plain text pairs: " + string.Join(", ", plainTextPairs));

            foreach (string pair in plainTextPairs)
            {
                bool flag = false;
                int j0;
                int j1;

                foreach (string row in keyMatrix)
                {
                    if (pair[0] == pair[1] && pair[1] == 'x')
                        break;

                    if (row.Contains(pair[0]) && row.Contains(pair[1]))
                    {
                        j0 = row.IndexOf(pair[0]);
                        j1 = row.IndexOf(pair[1]);
                        cipherTextPairs.Add($"{row[(j0 + 1) % 5]}{row[(j1 + 1) % 5]}");
                        flag = true;
                    }
                }

                if (flag) continue;

                int i0;
                int i1;

                for (int j = 0; j < 5; j++)
                {
                    string col = new string(keyMatrix.Select(row => row[j]).ToArray());

                    if (col.Contains(pair[0]) && col.Contains(pair[1]))
                    {
                        i0 = col.IndexOf(pair[0]);
                        i1 = col.IndexOf(pair[1]);
                        cipherTextPairs.Add($"{col[(i0 + 1) % 5]}{col[(i1 + 1) % 5]}");
                        flag = true;
                    }
                }

                if (flag) continue;

                i0 = 0;
                i1 = 0;
                j0 = 0;
                j1 = 0;

                for (int k = 0; k < 5; k++)
                {
                    string row = keyMatrix[k];
                    if (pair[0] == pair[1] && pair[1] == 'x')
                        break;

                    if (row.Contains(pair[0]))
                    {
                        i0 = k;
                        j0 = row.IndexOf(pair[0]);
                    }

                    if (row.Contains(pair[1]))
                    {
                        i1 = k;
                        j1 = row.IndexOf(pair[1]);
                    }
                }

                cipherTextPairs.Add($"{keyMatrix[i0][j1]}{keyMatrix[i1][j0]}");
            }

            Console.WriteLine("Cipher text pairs: " + string.Join(", ", cipherTextPairs));
            Console.WriteLine("Plain text: " + plainText);
            Console.WriteLine("Cipher text: " + string.Join("", cipherTextPairs));
            tb_PF_Result.Text = string.Join("", cipherTextPairs);

            // Here, you can update your UI elements to display the results
            // For example:
            // txtCipherText.Text = string.Join("", cipherTextPairs);
        }

        private void Decryption(string cipherText)
        {
            List<string> cipherTextPairs = new List<string>();
            List<string> plainTextPairs = new List<string>();

            cipherText = cipherText.ToLower();

            int i = 0;

            while (i < cipherText.Length)
            {
                char a = cipherText[i];
                char b = cipherText[i + 1];

                cipherTextPairs.Add($"{a}{b}");
                i += 2;
            }

            Console.WriteLine("Cipher text pairs: " + string.Join(", ", cipherTextPairs));

            foreach (string pair in cipherTextPairs)
            {
                bool flag = false;
                int j0;
                int j1;

                foreach (string row in keyMatrix)
                {
                    if (pair[0] == pair[1] && pair[1] == 'x')
                        break;

                    if (row.Contains(pair[0]) && row.Contains(pair[1]))
                    {
                        j0 = row.IndexOf(pair[0]);
                        j1 = row.IndexOf(pair[1]);
                        plainTextPairs.Add($"{row[(j0 + 4) % 5]}{row[(j1 + 4) % 5]}");
                        flag = true;
                    }
                }

                if (flag) continue;

                int i0;
                int i1;

                for (int j = 0; j < 5; j++)
                {
                    string col = new string(keyMatrix.Select(row => row[j]).ToArray());

                    if (col.Contains(pair[0]) && col.Contains(pair[1]))
                    {
                        i0 = col.IndexOf(pair[0]);
                        i1 = col.IndexOf(pair[1]);
                        plainTextPairs.Add($"{col[(i0 + 4) % 5]}{col[(i1 + 4) % 5]}");
                        flag = true;
                    }
                }

                if (flag) continue;

                i0 = 0;
                i1 = 0;
                j0 = 0;
                j1 = 0;

                for (int k = 0; k < 5; k++)
                {
                    string row = keyMatrix[k];
                    if (pair[0] == pair[1] && pair[1] == 'x')
                        break;

                    if (row.Contains(pair[0]))
                    {
                        i0 = k;
                        j0 = row.IndexOf(pair[0]);
                    }

                    if (row.Contains(pair[1]))
                    {
                        i1 = k;
                        j1 = row.IndexOf(pair[1]);
                    }
                }

                plainTextPairs.Add($"{keyMatrix[i0][j1]}{keyMatrix[i1][j0]}");
            }

            Console.WriteLine("Plain text pairs: " + string.Join(", ", plainTextPairs));

            Console.WriteLine("Cipher text: " + string.Join("", cipherTextPairs));
            Console.WriteLine("Plain text (message): " + string.Join("", plainTextPairs));
            tb_PF_Result.Text = string.Join("", plainTextPairs);

            // Here, you can update your UI elements to display the results
            // For example:
            // txtPlainText.Text = string.Join("", plainTextPairs);
        }

        private void DisplayMatrix(List<string> matrix)
        {
            panel_Matrix.Controls.Clear();
            int size = matrix.Count;
            char[] arr;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr = matrix[i].ToCharArray();


                    var btn = new Button()
                    {
                        Width = 30,
                        Height = 30,
                        Location = new Point(j * 30, i * 30), // Use simple coordinates
                        Text = arr[j].ToString()
                    };

                    btnList[i, j] = btn;
                    panel_Matrix.Controls.Add(btn);
                }
            }
        }

        private void PrintMatrix(List<string> matrix)
        {
            foreach (string row in matrix)
            {
                Console.WriteLine(row);
            }
        }
    }
}
