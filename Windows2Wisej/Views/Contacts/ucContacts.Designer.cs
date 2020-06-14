using System.Windows.Forms;

namespace Windows2Wisej.Views.Contacts
{
    partial class ucContacts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colContactid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContacts = new Windows2Wisej.Model.dsContacts();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbContactType = new System.Windows.Forms.ComboBox();
            this.lstContactsTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBirthDay = new System.Windows.Forms.DateTimePicker();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lstCountriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProvinces = new System.Windows.Forms.ComboBox();
            this.lstProvincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.lstCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contactsTableAdapter = new Windows2Wisej.Model.dsContactsTableAdapters.ContactsTableAdapter();
            this.lst_CitiesTableAdapter = new Windows2Wisej.Model.dsContactsTableAdapters.lst_CitiesTableAdapter();
            this.lst_ProvincesTableAdapter = new Windows2Wisej.Model.dsContactsTableAdapters.lst_ProvincesTableAdapter();
            this.lst_CountriesTableAdapter = new Windows2Wisej.Model.dsContactsTableAdapters.lst_CountriesTableAdapter();
            this.lst_Contacts_TypesTableAdapter = new Windows2Wisej.Model.dsContactsTableAdapters.lst_Contacts_TypesTableAdapter();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContacts)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstContactsTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCountriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProvincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.dataGridView1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(305, 553);
            this.pnlSearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactid,
            this.colFirstname,
            this.colLastname});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // colContactid
            // 
            this.colContactid.DataPropertyName = "ContactID";
            this.colContactid.HeaderText = "ID";
            this.colContactid.MinimumWidth = 8;
            this.colContactid.Name = "colContactid";
            this.colContactid.ReadOnly = true;
            this.colContactid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colContactid.Width = 60;
            // 
            // colFirstname
            // 
            this.colFirstname.DataPropertyName = "FirstName";
            this.colFirstname.HeaderText = "FirstName";
            this.colFirstname.Name = "colFirstname";
            // 
            // colLastname
            // 
            this.colLastname.DataPropertyName = "LastName";
            this.colLastname.HeaderText = "LastName";
            this.colLastname.Name = "colLastname";
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.dsContacts;
            // 
            // dsContacts
            // 
            this.dsContacts.DataSetName = "dsContacts";
            this.dsContacts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnRefresh);
            this.pnlData.Controls.Add(this.txtNotes);
            this.pnlData.Controls.Add(this.btnDelete);
            this.pnlData.Controls.Add(this.btnNew);
            this.pnlData.Controls.Add(this.btnSave);
            this.pnlData.Controls.Add(this.cbContactType);
            this.pnlData.Controls.Add(this.dataBirthDay);
            this.pnlData.Controls.Add(this.cbCountry);
            this.pnlData.Controls.Add(this.cbProvinces);
            this.pnlData.Controls.Add(this.cbCities);
            this.pnlData.Controls.Add(this.txtPostalCode);
            this.pnlData.Controls.Add(this.textBox3);
            this.pnlData.Controls.Add(this.textBox2);
            this.pnlData.Controls.Add(this.textBox1);
            this.pnlData.Controls.Add(this.label10);
            this.pnlData.Controls.Add(this.label9);
            this.pnlData.Controls.Add(this.label8);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(305, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(644, 553);
            this.pnlData.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(463, 433);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 27);
            this.btnRefresh.TabIndex = 24;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Notes", true));
            this.txtNotes.Location = new System.Drawing.Point(142, 326);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(421, 90);
            this.txtNotes.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 27);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "&Delete Contact";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(142, 433);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 27);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "&New Contact";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 27);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbContactType
            // 
            this.cbContactType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lstContactsTypesBindingSource, "ContactTypeId", true));
            this.cbContactType.DataSource = this.lstContactsTypesBindingSource;
            this.cbContactType.DisplayMember = "ContactType";
            this.cbContactType.Location = new System.Drawing.Point(142, 290);
            this.cbContactType.Name = "cbContactType";
            this.cbContactType.Size = new System.Drawing.Size(143, 21);
            this.cbContactType.TabIndex = 19;
            // 
            // lstContactsTypesBindingSource
            // 
            this.lstContactsTypesBindingSource.DataMember = "lst_Contacts_Types";
            this.lstContactsTypesBindingSource.DataSource = this.dsContacts;
            // 
            // dataBirthDay
            // 
            this.dataBirthDay.Checked = false;
            this.dataBirthDay.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contactsBindingSource, "DOB", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.dataBirthDay.Location = new System.Drawing.Point(140, 245);
            this.dataBirthDay.Name = "dataBirthDay";
            this.dataBirthDay.Size = new System.Drawing.Size(200, 20);
            this.dataBirthDay.TabIndex = 18;
            this.dataBirthDay.Value = new System.DateTime(2020, 6, 11, 17, 21, 45, 279);
            // 
            // cbCountry
            // 
            this.cbCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contactsBindingSource, "CountryID", true));
            this.cbCountry.DataSource = this.lstCountriesBindingSource;
            this.cbCountry.DisplayMember = "Country";
            this.cbCountry.Location = new System.Drawing.Point(144, 124);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(139, 21);
            this.cbCountry.TabIndex = 9;
            this.cbCountry.ValueMember = "CountryID";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lstCountriesBindingSource
            // 
            this.lstCountriesBindingSource.DataMember = "lst_Countries";
            this.lstCountriesBindingSource.DataSource = this.dsContacts;
            // 
            // cbProvinces
            // 
            this.cbProvinces.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contactsBindingSource, "ProvinceID", true));
            this.cbProvinces.DataSource = this.lstProvincesBindingSource;
            this.cbProvinces.DisplayMember = "Province";
            this.cbProvinces.Location = new System.Drawing.Point(143, 156);
            this.cbProvinces.Name = "cbProvinces";
            this.cbProvinces.Size = new System.Drawing.Size(140, 21);
            this.cbProvinces.TabIndex = 11;
            this.cbProvinces.ValueMember = "ProvinceId";
            this.cbProvinces.SelectedIndexChanged += new System.EventHandler(this.cbProvinces_SelectedIndexChanged);
            // 
            // lstProvincesBindingSource
            // 
            this.lstProvincesBindingSource.DataMember = "lst_Provinces";
            this.lstProvincesBindingSource.DataSource = this.dsContacts;
            // 
            // cbCities
            // 
            this.cbCities.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contactsBindingSource, "CityID", true));
            this.cbCities.DataSource = this.lstCitiesBindingSource;
            this.cbCities.DisplayMember = "City";
            this.cbCities.Location = new System.Drawing.Point(143, 184);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(140, 21);
            this.cbCities.TabIndex = 13;
            this.cbCities.ValueMember = "CityID";
            // 
            // lstCitiesBindingSource
            // 
            this.lstCitiesBindingSource.DataMember = "lst_Cities";
            this.lstCitiesBindingSource.DataSource = this.dsContacts;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "PostalCode", true));
            this.txtPostalCode.Location = new System.Drawing.Point(142, 212);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(143, 20);
            this.txtPostalCode.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Address", true));
            this.textBox3.Location = new System.Drawing.Point(142, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "LastName", true));
            this.textBox2.Location = new System.Drawing.Point(142, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "FirstName", true));
            this.textBox1.Location = new System.Drawing.Point(142, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Notes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Contact Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Province/State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // lst_CitiesTableAdapter
            // 
            this.lst_CitiesTableAdapter.ClearBeforeFill = true;
            // 
            // lst_ProvincesTableAdapter
            // 
            this.lst_ProvincesTableAdapter.ClearBeforeFill = true;
            // 
            // lst_CountriesTableAdapter
            // 
            this.lst_CountriesTableAdapter.ClearBeforeFill = true;
            // 
            // lst_Contacts_TypesTableAdapter
            // 
            this.lst_Contacts_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // ucContacts
            // 
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ucContacts";
            this.Size = new System.Drawing.Size(949, 553);
            this.Load += new System.EventHandler(this.ucContacts_Load);
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContacts)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstContactsTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCountriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstProvincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colContactid;
        private DataGridViewTextBoxColumn colFirstname;
        private DataGridViewTextBoxColumn colLastname;
        private BindingSource contactsBindingSource;
        private Model.dsContacts dsContacts;
        private Panel pnlData;
        private Model.dsContactsTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPostalCode;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cbCities;
        private BindingSource lstCitiesBindingSource;
        private Model.dsContactsTableAdapters.lst_CitiesTableAdapter lst_CitiesTableAdapter;
        private ComboBox cbProvinces;
        private BindingSource lstProvincesBindingSource;
        private Model.dsContactsTableAdapters.lst_ProvincesTableAdapter lst_ProvincesTableAdapter;
        private ComboBox cbCountry;
        private BindingSource lstCountriesBindingSource;
        private Model.dsContactsTableAdapters.lst_CountriesTableAdapter lst_CountriesTableAdapter;
        private Button btnSave;
        private ComboBox cbContactType;
        private BindingSource lstContactsTypesBindingSource;
        private DateTimePicker dataBirthDay;
        private Model.dsContactsTableAdapters.lst_Contacts_TypesTableAdapter lst_Contacts_TypesTableAdapter;
        private Button btnNew;
        private Button btnDelete;
        private TextBox txtNotes;
        private Button btnRefresh;
    }
}
