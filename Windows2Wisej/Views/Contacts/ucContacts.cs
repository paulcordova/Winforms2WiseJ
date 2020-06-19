using System;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows2Wisej.Views.Contacts
{
    public partial class ucContacts : UserControl
    {
        public ucContacts()
        {
            InitializeComponent();
        }

        private void ucContacts_Load(object sender, EventArgs e)
        {
            LoadDataContacts();
            LoadDataCountries();
            LoadDataProvinces();
            LoadDataCities();
            LoadDataContactType();
            LoadDataEmailType();
            LoadDataPhoneType();
           // LoadDataClientEmail();
           // LoadDataClientPhones();
        }


        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null)
            {
                string sCountryID = cb.SelectedValue.ToString();
                FilterDataProvinces(sCountryID);
            }
        }


        private void cbProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedValue != null)
            {
                string sProvinceID = cb.SelectedValue.ToString();
                FilterDataCitiesByProvince(sProvinceID);
            }
        }
       
        private void LoadDataContacts()
        {
            //1. Fill the DataSet
            contactsTableAdapter.Fill(dsContacts.Contacts);
            //2. Add DataSource to binding Source
            contactsBindingSource.DataSource = dsContacts.Contacts;
            //3. Set DataGridView datasource
            dataGridView1.DataSource = contactsBindingSource;
        }

        private void LoadDataCountries()
        {
            this.lst_CountriesTableAdapter.Fill(dsContacts.lst_Countries);
            lstCountriesBindingSource.DataSource = dsContacts.lst_Countries;
            cbCountry.DataSource = lstCountriesBindingSource;
        }

        private void LoadDataCities()
        {
            lst_CitiesTableAdapter.Fill(dsContacts.lst_Cities);
            lstCitiesBindingSource.DataSource = dsContacts.lst_Cities;
            cbCities.DataSource = lstCitiesBindingSource;
        }

        private void LoadDataProvinces(string sProvinceID = null)
        {
            lst_ProvincesTableAdapter.Fill(dsContacts.lst_Provinces);
            lstProvincesBindingSource.DataSource = dsContacts.lst_Provinces;
            cbProvinces.DataSource = lstProvincesBindingSource;
        }

        private void LoadDataContactType()
        {
            lst_Contacts_TypesTableAdapter.Fill(dsContacts.lst_Contacts_Types);
            lstContactsTypesBindingSource.DataSource = dsContacts.lst_Contacts_Types;
            cbContactType.DataSource = lstContactsTypesBindingSource;
        }

        private void LoadDataEmailType()
        {
            lst_EmailAddressTypesTableAdapter.Fill(dsContacts.lst_EmailAddressTypes);
        }

        private void LoadDataPhoneType()
        {
            lst_PhoneNumbersCategoriesTableAdapter.Fill(dsContacts.lst_PhoneNumbersCategories);
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            GetSelectedContact();

        }

        private void GetSelectedContact()
        {
            int pContactID = 0;
                        
            DataRowView drw = (DataRowView)contactsBindingSource.Current;
            Model.dsContacts.ContactsRow crw;
            
            if (drw != null)
            {
                crw = (Model.dsContacts.ContactsRow)drw.Row;

                pContactID = (int)drw.Row.ItemArray[0];
                pContactID = crw.ContactID;
                LoadDataClientEmail(pContactID);
                LoadDataClientPhones(pContactID);
            }
        }

        private void GetSelectedContactTypedDatarow()
        {
            int pContactID = 0;
            Model.dsContacts.ContactsRow crw;

            //crw = (Model.dsContacts.ContactsRow)dr
        }

        private void LoadDataClientEmail(int pContactID)
        {
           
            this.contacts_EmailAddressesTableAdapter.FillBy(dsContacts.Contacts_EmailAddresses, pContactID);
        }

        private void LoadDataClientPhones(int pContactID = 0)
        {
            this.contacts_PhoneNumbersTableAdapter.FillBy(dsContacts.Contacts_PhoneNumbers, pContactID);
        }

        private void FilterDataProvinces(string sCountryID = null)
        {
            if (sCountryID != null)
            {
                lstProvincesBindingSource.Filter = "CountryID = " + sCountryID;
            }
            else
            {
                lstProvincesBindingSource.Filter = null;
            }
        }

        private void FilterDataCitiesByProvince(string sProvinceID = null)
        {
            if (sProvinceID != null)
            {
                lstCitiesBindingSource.Filter = "ProvinceID = " + sProvinceID;
            }
            else
            {
                lstCitiesBindingSource.Filter = null;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // New record in the DataSet
            this.contactsBindingSource.AddNew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.contactsBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the Database
            try
            {
                this.Validate();
                this.contactsBindingSource.EndEdit();
                this.contactsTableAdapter.Update(this.dsContacts.Contacts);

                this.contacts_EmailAddressesBindingSource.EndEdit();
                this.contacts_EmailAddressesTableAdapter.Update(this.dsContacts.Contacts_EmailAddresses);

                this.contacts_PhoneNumbersBindingSource.EndEdit();
                this.contacts_PhoneNumbersTableAdapter.Update(this.dsContacts.Contacts_PhoneNumbers);
           
                //AlertBox.Show("Data updated...");
            }
            catch (Exception ex)
            {
                //AlertBox.Show(ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataContacts();
        }


    }
}
