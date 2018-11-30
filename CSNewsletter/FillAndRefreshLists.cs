using System;
using System.Data;
using System.Windows.Forms;

namespace CSNewsletter
{
    static class FillAndRefreshLists
    {
        static public bool NewslettersComboBox(ref ComboBox comboBox, bool includeIDInTitle)
        {
            DataTable dataTable = null;
            if (Program.Database.OpenDataTable(ref dataTable, "SELECT ID, " + (includeIDInTitle ? "ID & ' - ' & " : "") + "Title AS Description FROM Newsletter ORDER BY ID DESC", "Newsletter", "Error al leer la lista de Newsletters."))
            {
                comboBox.ValueMember = "ID";
                comboBox.DisplayMember = "Description";
                comboBox.DataSource = dataTable;
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool ArticlesListBox(ref ListBox listBox, bool includeIDInTitle, short newsletterID)
        {
            DataTable dataTable = null;
            if (Program.Database.OpenDataTable(ref dataTable, string.Format("SELECT ID, " + (includeIDInTitle ? "ID & ' - ' & " : "") + "Title AS Description FROM NewsletterArticle WHERE newsletterID = {0} ORDER BY OrderNumber, ID DESC", newsletterID), "Newsletter", "Error al leer la lista de Artículos."))
            {
                listBox.ValueMember = "ID";
                listBox.DisplayMember = "Description";
                listBox.DataSource = dataTable;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
