using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSNewsletter
{
    static class Program
    {
        public static CardonerSistemas.Database_ADO_OleDb pDatabase = new CardonerSistemas.Database_ADO_OleDb();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Preparo el ConnectionString para las conexiones a la base de datos            
            pDatabase.Provider = CardonerSistemas.Database_ADO_OleDb.ProviderOffice12Access;
            pDatabase.DataSource = Properties.Settings.Default.DBConnection_DataSource;
            pDatabase.UserID = Properties.Settings.Default.DBConnection_UserID;
            // Desencripto la contraseña de la conexión a la base de datos que está en el archivo app.config
            CardonerSistemas.Encrypt_TripleDES PasswordDecrypter = new CardonerSistemas.Encrypt_TripleDES(CardonerSistemas.Constants.PublicEncryptionPassword);
            string DecryptedPassword = "";
            if (!PasswordDecrypter.Decrypt(Properties.Settings.Default.DBConnection_Password, ref DecryptedPassword))
            {
                MessageBox.Show("La contraseña de conexión a la base de datos es incorrecta.", CardonerSistemas.My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //formSplashScreen.Close()
                //formSplashScreen.Dispose()
                //TerminateApplication()
                return;
            }
            pDatabase.Password = DecryptedPassword;
            PasswordDecrypter = null;
            pDatabase.CreateConnectionString();

            if (!pDatabase.Connect())
            {
                return;
            }

            Application.Run(new formMain());
        }
    }
}
