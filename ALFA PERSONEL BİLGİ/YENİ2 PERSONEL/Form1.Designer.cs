namespace YENİ2_PERSONEL
{
    partial class Form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Personel_Bilgi_GBOX = new System.Windows.Forms.GroupBox();
            this.gorev_txt = new System.Windows.Forms.ComboBox();
            this.görev_lbl = new System.Windows.Forms.Label();
            this.grup_txt = new System.Windows.Forms.ComboBox();
            this.grup_lbl = new System.Windows.Forms.Label();
            this.firma_txt = new System.Windows.Forms.ComboBox();
            this.firma_lbl = new System.Windows.Forms.Label();
            this.birim_txt = new System.Windows.Forms.ComboBox();
            this.birim_lbl = new System.Windows.Forms.Label();
            this.sicil_txt = new System.Windows.Forms.TextBox();
            this.sicil_lbl = new System.Windows.Forms.Label();
            this.bolum_txt = new System.Windows.Forms.ComboBox();
            this.sil_btn = new System.Windows.Forms.Button();
            this.listele_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.temizle_btn = new System.Windows.Forms.Button();
            this.bölüm_lbl = new System.Windows.Forms.Label();
            this.acil_tel_txt = new System.Windows.Forms.TextBox();
            this.acil_tel_lbl = new System.Windows.Forms.Label();
            this.tel_txt = new System.Windows.Forms.TextBox();
            this.telefon_lbl = new System.Windows.Forms.Label();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.tc_lbl = new System.Windows.Forms.Label();
            this.soyad_txt = new System.Windows.Forms.TextBox();
            this.soyad_lbl = new System.Windows.Forms.Label();
            this.ad_txt = new System.Windows.Forms.TextBox();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.personel_txt = new System.Windows.Forms.TextBox();
            this.Personel_No_lbl = new System.Windows.Forms.Label();
            this.filtre_gbox = new System.Windows.Forms.GroupBox();
            this.temizle_fltr_btn = new System.Windows.Forms.Button();
            this.görev_fltr_cbox = new System.Windows.Forms.ComboBox();
            this.soyad_fltr_cbox = new System.Windows.Forms.TextBox();
            this.ad_fltr_lbl = new System.Windows.Forms.Label();
            this.görev_fltr_lbl = new System.Windows.Forms.Label();
            this.ad_fltr_cbox = new System.Windows.Forms.TextBox();
            this.soyad_fltr_lbl = new System.Windows.Forms.Label();
            this.grup_fltr_cbox = new System.Windows.Forms.ComboBox();
            this.grup_fltr_lbl = new System.Windows.Forms.Label();
            this.blm_fltr_cbox = new System.Windows.Forms.ComboBox();
            this.sicil_fltr_lbl = new System.Windows.Forms.Label();
            this.sicil_fltr_cbox = new System.Windows.Forms.TextBox();
            this.blm_fltr_lbl = new System.Windows.Forms.Label();
            this.firma_fltr_cbox = new System.Windows.Forms.ComboBox();
            this.brm_fltr_cbox = new System.Windows.Forms.ComboBox();
            this.brm_fltr_lbl = new System.Windows.Forms.Label();
            this.firma_fltr_lbl = new System.Windows.Forms.Label();
            this.kayıt_gbox = new System.Windows.Forms.GroupBox();
            this.alfapersonelBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaDataSet7 = new YENİ2_PERSONEL.personel_alfaDataSet7();
            this.alfapersonelBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaDataSet6 = new YENİ2_PERSONEL.personel_alfaDataSet6();
            this.alfapersonelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaDataSet5 = new YENİ2_PERSONEL.personel_alfaDataSet5();
            this.alfapersonelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaDataSet4 = new YENİ2_PERSONEL.personel_alfaDataSet4();
            this.alfapersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaDataSet3 = new YENİ2_PERSONEL.personel_alfaDataSet3();
            this.alfapersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaDataSet2 = new YENİ2_PERSONEL.personel_alfaDataSet2();
            this.personelalfaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaDataSet1 = new YENİ2_PERSONEL.personel_alfaDataSet1();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet = new YENİ2_PERSONEL.personelDataSet();
            this.personelTableAdapter = new YENİ2_PERSONEL.personelDataSetTableAdapters.personelTableAdapter();
            this.personel_alfaDataSet = new YENİ2_PERSONEL.personel_alfaDataSet();
            this.personelalfaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_alfaTableAdapter = new YENİ2_PERSONEL.personel_alfaDataSetTableAdapters.personel_alfaTableAdapter();
            this.personel_alfaTableAdapter1 = new YENİ2_PERSONEL.personel_alfaDataSet1TableAdapters.personel_alfaTableAdapter();
            this.çıktı_gbox = new System.Windows.Forms.GroupBox();
            this.excel_çıktı_btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.alfa_personelTableAdapter = new YENİ2_PERSONEL.personel_alfaDataSet2TableAdapters.alfa_personelTableAdapter();
            this.alfa_personelTableAdapter1 = new YENİ2_PERSONEL.personel_alfaDataSet3TableAdapters.alfa_personelTableAdapter();
            this.alfa_personelTableAdapter2 = new YENİ2_PERSONEL.personel_alfaDataSet4TableAdapters.alfa_personelTableAdapter();
            this.alfa_personelTableAdapter3 = new YENİ2_PERSONEL.personel_alfaDataSet5TableAdapters.alfa_personelTableAdapter();
            this.alfa_personelTableAdapter4 = new YENİ2_PERSONEL.personel_alfaDataSet6TableAdapters.alfa_personelTableAdapter();
            this.alfa_personelTableAdapter5 = new YENİ2_PERSONEL.personel_alfaDataSet7TableAdapters.alfa_personelTableAdapter();
            this.personel_alfaDataSet8 = new YENİ2_PERSONEL.personel_alfaDataSet8();
            this.alfapersonelBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.alfa_personelTableAdapter6 = new YENİ2_PERSONEL.personel_alfaDataSet8TableAdapters.alfa_personelTableAdapter();
            this.personel_alfaDataSet9 = new YENİ2_PERSONEL.personel_alfaDataSet9();
            this.alfapersonelBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.alfa_personelTableAdapter7 = new YENİ2_PERSONEL.personel_alfaDataSet9TableAdapters.alfa_personelTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sıraNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acilTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bırımDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fırmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel_alfaDataSet10 = new YENİ2_PERSONEL.personel_alfaDataSet10();
            this.alfapersonelBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.alfa_personelTableAdapter8 = new YENİ2_PERSONEL.personel_alfaDataSet10TableAdapters.alfa_personelTableAdapter();
            this.Personel_Bilgi_GBOX.SuspendLayout();
            this.filtre_gbox.SuspendLayout();
            this.kayıt_gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelalfaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelalfaBindingSource)).BeginInit();
            this.çıktı_gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // Personel_Bilgi_GBOX
            // 
            this.Personel_Bilgi_GBOX.Controls.Add(this.gorev_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.görev_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.grup_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.grup_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.firma_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.firma_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.birim_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.birim_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.sicil_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.sicil_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.bolum_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.sil_btn);
            this.Personel_Bilgi_GBOX.Controls.Add(this.listele_btn);
            this.Personel_Bilgi_GBOX.Controls.Add(this.guncelle_btn);
            this.Personel_Bilgi_GBOX.Controls.Add(this.kaydet_btn);
            this.Personel_Bilgi_GBOX.Controls.Add(this.temizle_btn);
            this.Personel_Bilgi_GBOX.Controls.Add(this.bölüm_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.acil_tel_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.acil_tel_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.tel_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.telefon_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.tc_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.tc_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.soyad_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.soyad_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.ad_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.ad_lbl);
            this.Personel_Bilgi_GBOX.Controls.Add(this.personel_txt);
            this.Personel_Bilgi_GBOX.Controls.Add(this.Personel_No_lbl);
            this.Personel_Bilgi_GBOX.Location = new System.Drawing.Point(11, 11);
            this.Personel_Bilgi_GBOX.Margin = new System.Windows.Forms.Padding(2);
            this.Personel_Bilgi_GBOX.Name = "Personel_Bilgi_GBOX";
            this.Personel_Bilgi_GBOX.Padding = new System.Windows.Forms.Padding(2);
            this.Personel_Bilgi_GBOX.Size = new System.Drawing.Size(275, 1019);
            this.Personel_Bilgi_GBOX.TabIndex = 2;
            this.Personel_Bilgi_GBOX.TabStop = false;
            this.Personel_Bilgi_GBOX.Text = "PERSONEL";
            this.Personel_Bilgi_GBOX.Enter += new System.EventHandler(this.Personel_Bilgi_GBOX_Enter);
            // 
            // gorev_txt
            // 
            this.gorev_txt.FormattingEnabled = true;
            this.gorev_txt.Items.AddRange(new object[] {
            ""});
            this.gorev_txt.Location = new System.Drawing.Point(118, 313);
            this.gorev_txt.Name = "gorev_txt";
            this.gorev_txt.Size = new System.Drawing.Size(134, 21);
            this.gorev_txt.TabIndex = 10;
            this.gorev_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.görev_txt_KeyPress);
            // 
            // görev_lbl
            // 
            this.görev_lbl.AutoSize = true;
            this.görev_lbl.Location = new System.Drawing.Point(18, 321);
            this.görev_lbl.Name = "görev_lbl";
            this.görev_lbl.Size = new System.Drawing.Size(48, 13);
            this.görev_lbl.TabIndex = 27;
            this.görev_lbl.Text = "GÖREV:";
            // 
            // grup_txt
            // 
            this.grup_txt.FormattingEnabled = true;
            this.grup_txt.Location = new System.Drawing.Point(118, 289);
            this.grup_txt.Name = "grup_txt";
            this.grup_txt.Size = new System.Drawing.Size(134, 21);
            this.grup_txt.TabIndex = 9;
            this.grup_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grup_txt_KeyPress);
            // 
            // grup_lbl
            // 
            this.grup_lbl.AutoSize = true;
            this.grup_lbl.Location = new System.Drawing.Point(18, 294);
            this.grup_lbl.Name = "grup_lbl";
            this.grup_lbl.Size = new System.Drawing.Size(41, 13);
            this.grup_lbl.TabIndex = 25;
            this.grup_lbl.Text = "GRUP:";
            // 
            // firma_txt
            // 
            this.firma_txt.FormattingEnabled = true;
            this.firma_txt.Location = new System.Drawing.Point(118, 262);
            this.firma_txt.Name = "firma_txt";
            this.firma_txt.Size = new System.Drawing.Size(134, 21);
            this.firma_txt.TabIndex = 8;
            this.firma_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firma_txt_KeyPress);
            // 
            // firma_lbl
            // 
            this.firma_lbl.AutoSize = true;
            this.firma_lbl.Location = new System.Drawing.Point(18, 267);
            this.firma_lbl.Name = "firma_lbl";
            this.firma_lbl.Size = new System.Drawing.Size(43, 13);
            this.firma_lbl.TabIndex = 23;
            this.firma_lbl.Text = "FİRMA:";
            // 
            // birim_txt
            // 
            this.birim_txt.FormattingEnabled = true;
            this.birim_txt.Location = new System.Drawing.Point(118, 235);
            this.birim_txt.Name = "birim_txt";
            this.birim_txt.Size = new System.Drawing.Size(134, 21);
            this.birim_txt.TabIndex = 7;
            this.birim_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birim_txt_KeyPress);
            // 
            // birim_lbl
            // 
            this.birim_lbl.AutoSize = true;
            this.birim_lbl.Location = new System.Drawing.Point(18, 241);
            this.birim_lbl.Name = "birim_lbl";
            this.birim_lbl.Size = new System.Drawing.Size(40, 13);
            this.birim_lbl.TabIndex = 21;
            this.birim_lbl.Text = "BİRİM:";
            // 
            // sicil_txt
            // 
            this.sicil_txt.Location = new System.Drawing.Point(118, 49);
            this.sicil_txt.Multiline = true;
            this.sicil_txt.Name = "sicil_txt";
            this.sicil_txt.Size = new System.Drawing.Size(134, 20);
            this.sicil_txt.TabIndex = 0;
            this.sicil_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sicil_txt_KeyPress);
            // 
            // sicil_lbl
            // 
            this.sicil_lbl.AutoSize = true;
            this.sicil_lbl.Location = new System.Drawing.Point(18, 52);
            this.sicil_lbl.Name = "sicil_lbl";
            this.sicil_lbl.Size = new System.Drawing.Size(55, 13);
            this.sicil_lbl.TabIndex = 19;
            this.sicil_lbl.Text = "SİCİL NO:";
            // 
            // bolum_txt
            // 
            this.bolum_txt.FormattingEnabled = true;
            this.bolum_txt.Location = new System.Drawing.Point(118, 208);
            this.bolum_txt.Name = "bolum_txt";
            this.bolum_txt.Size = new System.Drawing.Size(134, 21);
            this.bolum_txt.TabIndex = 6;
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(85, 410);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(75, 23);
            this.sil_btn.TabIndex = 44;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // listele_btn
            // 
            this.listele_btn.Location = new System.Drawing.Point(139, 381);
            this.listele_btn.Name = "listele_btn";
            this.listele_btn.Size = new System.Drawing.Size(75, 23);
            this.listele_btn.TabIndex = 43;
            this.listele_btn.Text = "YENİLE";
            this.listele_btn.UseVisualStyleBackColor = true;
            this.listele_btn.Click += new System.EventHandler(this.listele_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(29, 381);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(75, 23);
            this.guncelle_btn.TabIndex = 41;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.güncelle_btn_Click);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(139, 352);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(75, 23);
            this.kaydet_btn.TabIndex = 42;
            this.kaydet_btn.Text = "KAYDET";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // temizle_btn
            // 
            this.temizle_btn.Location = new System.Drawing.Point(29, 352);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(75, 23);
            this.temizle_btn.TabIndex = 40;
            this.temizle_btn.Text = "TEMİZLE";
            this.temizle_btn.UseVisualStyleBackColor = true;
            this.temizle_btn.Click += new System.EventHandler(this.temizle_btn_Click);
            // 
            // bölüm_lbl
            // 
            this.bölüm_lbl.AutoSize = true;
            this.bölüm_lbl.Location = new System.Drawing.Point(18, 213);
            this.bölüm_lbl.Name = "bölüm_lbl";
            this.bölüm_lbl.Size = new System.Drawing.Size(48, 13);
            this.bölüm_lbl.TabIndex = 12;
            this.bölüm_lbl.Text = "BÖLÜM:";
            // 
            // acil_tel_txt
            // 
            this.acil_tel_txt.Location = new System.Drawing.Point(118, 179);
            this.acil_tel_txt.MaxLength = 11;
            this.acil_tel_txt.Name = "acil_tel_txt";
            this.acil_tel_txt.Size = new System.Drawing.Size(134, 20);
            this.acil_tel_txt.TabIndex = 5;
            this.acil_tel_txt.TextChanged += new System.EventHandler(this.acil_tel_txt_TextChanged);
            this.acil_tel_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.acil_tel_txt_KeyDown);
            this.acil_tel_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.acil_tel_txt_KeyPress);
            // 
            // acil_tel_lbl
            // 
            this.acil_tel_lbl.AutoSize = true;
            this.acil_tel_lbl.Location = new System.Drawing.Point(18, 183);
            this.acil_tel_lbl.Name = "acil_tel_lbl";
            this.acil_tel_lbl.Size = new System.Drawing.Size(100, 13);
            this.acil_tel_lbl.TabIndex = 10;
            this.acil_tel_lbl.Text = "ACİL DURUM TEL:";
            // 
            // tel_txt
            // 
            this.tel_txt.Location = new System.Drawing.Point(118, 153);
            this.tel_txt.MaxLength = 11;
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(134, 20);
            this.tel_txt.TabIndex = 4;
            this.tel_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tel_txt_KeyDown);
            this.tel_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_txt_KeyPress);
            // 
            // telefon_lbl
            // 
            this.telefon_lbl.AutoSize = true;
            this.telefon_lbl.Location = new System.Drawing.Point(18, 156);
            this.telefon_lbl.Name = "telefon_lbl";
            this.telefon_lbl.Size = new System.Drawing.Size(59, 13);
            this.telefon_lbl.TabIndex = 8;
            this.telefon_lbl.Text = "TELEFON:";
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(118, 127);
            this.tc_txt.MaxLength = 11;
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(134, 20);
            this.tc_txt.TabIndex = 3;
            this.tc_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tc_txt_KeyDown);
            this.tc_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_txt_KeyPress);
            // 
            // tc_lbl
            // 
            this.tc_lbl.AutoSize = true;
            this.tc_lbl.Location = new System.Drawing.Point(18, 130);
            this.tc_lbl.Name = "tc_lbl";
            this.tc_lbl.Size = new System.Drawing.Size(81, 13);
            this.tc_lbl.TabIndex = 6;
            this.tc_lbl.Text = "TC KİMLİK NO:";
            // 
            // soyad_txt
            // 
            this.soyad_txt.Location = new System.Drawing.Point(118, 101);
            this.soyad_txt.MaxLength = 20;
            this.soyad_txt.Name = "soyad_txt";
            this.soyad_txt.Size = new System.Drawing.Size(134, 20);
            this.soyad_txt.TabIndex = 2;
            this.soyad_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.soyad_txt_KeyDown);
            this.soyad_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_txt_KeyPress);
            // 
            // soyad_lbl
            // 
            this.soyad_lbl.AutoSize = true;
            this.soyad_lbl.Location = new System.Drawing.Point(18, 104);
            this.soyad_lbl.Name = "soyad_lbl";
            this.soyad_lbl.Size = new System.Drawing.Size(50, 13);
            this.soyad_lbl.TabIndex = 4;
            this.soyad_lbl.Text = "SOYADI:";
            // 
            // ad_txt
            // 
            this.ad_txt.Location = new System.Drawing.Point(118, 75);
            this.ad_txt.MaxLength = 30;
            this.ad_txt.Name = "ad_txt";
            this.ad_txt.Size = new System.Drawing.Size(134, 20);
            this.ad_txt.TabIndex = 1;
            this.ad_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ad_txt_KeyDown);
            this.ad_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_txt_KeyPress);
            // 
            // ad_lbl
            // 
            this.ad_lbl.AutoSize = true;
            this.ad_lbl.Location = new System.Drawing.Point(18, 78);
            this.ad_lbl.Name = "ad_lbl";
            this.ad_lbl.Size = new System.Drawing.Size(28, 13);
            this.ad_lbl.TabIndex = 2;
            this.ad_lbl.Text = "ADI:";
            // 
            // personel_txt
            // 
            this.personel_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personel_txt.Location = new System.Drawing.Point(118, 23);
            this.personel_txt.Name = "personel_txt";
            this.personel_txt.ReadOnly = true;
            this.personel_txt.Size = new System.Drawing.Size(134, 20);
            this.personel_txt.TabIndex = 1;
            this.personel_txt.TabStop = false;
            // 
            // Personel_No_lbl
            // 
            this.Personel_No_lbl.AutoSize = true;
            this.Personel_No_lbl.Location = new System.Drawing.Point(18, 26);
            this.Personel_No_lbl.Name = "Personel_No_lbl";
            this.Personel_No_lbl.Size = new System.Drawing.Size(54, 13);
            this.Personel_No_lbl.TabIndex = 0;
            this.Personel_No_lbl.Text = "SIRA NO:";
            // 
            // filtre_gbox
            // 
            this.filtre_gbox.Controls.Add(this.temizle_fltr_btn);
            this.filtre_gbox.Controls.Add(this.görev_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.soyad_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.ad_fltr_lbl);
            this.filtre_gbox.Controls.Add(this.görev_fltr_lbl);
            this.filtre_gbox.Controls.Add(this.ad_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.soyad_fltr_lbl);
            this.filtre_gbox.Controls.Add(this.grup_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.grup_fltr_lbl);
            this.filtre_gbox.Controls.Add(this.blm_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.sicil_fltr_lbl);
            this.filtre_gbox.Controls.Add(this.sicil_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.blm_fltr_lbl);
            this.filtre_gbox.Controls.Add(this.firma_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.brm_fltr_cbox);
            this.filtre_gbox.Controls.Add(this.brm_fltr_lbl);
            this.filtre_gbox.Controls.Add(this.firma_fltr_lbl);
            this.filtre_gbox.Location = new System.Drawing.Point(291, 12);
            this.filtre_gbox.Name = "filtre_gbox";
            this.filtre_gbox.Size = new System.Drawing.Size(1409, 95);
            this.filtre_gbox.TabIndex = 4;
            this.filtre_gbox.TabStop = false;
            this.filtre_gbox.Text = "FİLTRE";
            // 
            // temizle_fltr_btn
            // 
            this.temizle_fltr_btn.Location = new System.Drawing.Point(1241, 28);
            this.temizle_fltr_btn.Name = "temizle_fltr_btn";
            this.temizle_fltr_btn.Size = new System.Drawing.Size(75, 23);
            this.temizle_fltr_btn.TabIndex = 4;
            this.temizle_fltr_btn.Text = "TEMİZLE";
            this.temizle_fltr_btn.UseVisualStyleBackColor = true;
            this.temizle_fltr_btn.Click += new System.EventHandler(this.temizle_fltr_btn_Click);
            // 
            // görev_fltr_cbox
            // 
            this.görev_fltr_cbox.FormattingEnabled = true;
            this.görev_fltr_cbox.Items.AddRange(new object[] {
            ""});
            this.görev_fltr_cbox.Location = new System.Drawing.Point(930, 43);
            this.görev_fltr_cbox.Name = "görev_fltr_cbox";
            this.görev_fltr_cbox.Size = new System.Drawing.Size(121, 21);
            this.görev_fltr_cbox.TabIndex = 7;
            this.görev_fltr_cbox.SelectedIndexChanged += new System.EventHandler(this.görev_fltr_cbox_SelectedIndexChanged);
            this.görev_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.görev_fltr_cbox_KeyPress);
            // 
            // soyad_fltr_cbox
            // 
            this.soyad_fltr_cbox.Location = new System.Drawing.Point(109, 43);
            this.soyad_fltr_cbox.MaxLength = 30;
            this.soyad_fltr_cbox.Name = "soyad_fltr_cbox";
            this.soyad_fltr_cbox.Size = new System.Drawing.Size(117, 20);
            this.soyad_fltr_cbox.TabIndex = 1;
            this.soyad_fltr_cbox.TextChanged += new System.EventHandler(this.soyad_fltr_cbox_TextChanged);
            this.soyad_fltr_cbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.soyad_fltr_cbox_KeyDown);
            this.soyad_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soyad_fltr_cbox_KeyPress);
            this.soyad_fltr_cbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.soyad_fltr_cbox_MouseDown);
            // 
            // ad_fltr_lbl
            // 
            this.ad_fltr_lbl.AutoSize = true;
            this.ad_fltr_lbl.Location = new System.Drawing.Point(53, 26);
            this.ad_fltr_lbl.Name = "ad_fltr_lbl";
            this.ad_fltr_lbl.Size = new System.Drawing.Size(28, 13);
            this.ad_fltr_lbl.TabIndex = 25;
            this.ad_fltr_lbl.Text = "ADI:";
            this.ad_fltr_lbl.Click += new System.EventHandler(this.ad_fltr_lbl_Click);
            // 
            // görev_fltr_lbl
            // 
            this.görev_fltr_lbl.AutoSize = true;
            this.görev_fltr_lbl.Location = new System.Drawing.Point(874, 51);
            this.görev_fltr_lbl.Name = "görev_fltr_lbl";
            this.görev_fltr_lbl.Size = new System.Drawing.Size(48, 13);
            this.görev_fltr_lbl.TabIndex = 38;
            this.görev_fltr_lbl.Text = "GÖREV:";
            // 
            // ad_fltr_cbox
            // 
            this.ad_fltr_cbox.Location = new System.Drawing.Point(109, 19);
            this.ad_fltr_cbox.MaxLength = 30;
            this.ad_fltr_cbox.Name = "ad_fltr_cbox";
            this.ad_fltr_cbox.Size = new System.Drawing.Size(117, 20);
            this.ad_fltr_cbox.TabIndex = 0;
            this.ad_fltr_cbox.TextChanged += new System.EventHandler(this.ad_fltr_cbox_TextChanged);
            this.ad_fltr_cbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ad_fltr_cbox_KeyDown);
            this.ad_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ad_fltr_cbox_KeyPress);
            // 
            // soyad_fltr_lbl
            // 
            this.soyad_fltr_lbl.AutoSize = true;
            this.soyad_fltr_lbl.Location = new System.Drawing.Point(53, 50);
            this.soyad_fltr_lbl.Name = "soyad_fltr_lbl";
            this.soyad_fltr_lbl.Size = new System.Drawing.Size(50, 13);
            this.soyad_fltr_lbl.TabIndex = 27;
            this.soyad_fltr_lbl.Text = "SOYADI:";
            // 
            // grup_fltr_cbox
            // 
            this.grup_fltr_cbox.FormattingEnabled = true;
            this.grup_fltr_cbox.Items.AddRange(new object[] {
            ""});
            this.grup_fltr_cbox.Location = new System.Drawing.Point(930, 16);
            this.grup_fltr_cbox.Name = "grup_fltr_cbox";
            this.grup_fltr_cbox.Size = new System.Drawing.Size(121, 21);
            this.grup_fltr_cbox.TabIndex = 6;
            this.grup_fltr_cbox.SelectedIndexChanged += new System.EventHandler(this.grup_fltr_cbox_SelectedIndexChanged);
            this.grup_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grup_fltr_cbox_KeyPress);
            // 
            // grup_fltr_lbl
            // 
            this.grup_fltr_lbl.AutoSize = true;
            this.grup_fltr_lbl.Location = new System.Drawing.Point(874, 24);
            this.grup_fltr_lbl.Name = "grup_fltr_lbl";
            this.grup_fltr_lbl.Size = new System.Drawing.Size(41, 13);
            this.grup_fltr_lbl.TabIndex = 36;
            this.grup_fltr_lbl.Text = "GRUP:";
            // 
            // blm_fltr_cbox
            // 
            this.blm_fltr_cbox.FormattingEnabled = true;
            this.blm_fltr_cbox.Items.AddRange(new object[] {
            ""});
            this.blm_fltr_cbox.Location = new System.Drawing.Point(366, 47);
            this.blm_fltr_cbox.Name = "blm_fltr_cbox";
            this.blm_fltr_cbox.Size = new System.Drawing.Size(121, 21);
            this.blm_fltr_cbox.TabIndex = 3;
            this.blm_fltr_cbox.SelectedIndexChanged += new System.EventHandler(this.blm_fltr_cbox_SelectedIndexChanged);
            this.blm_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blm_fltr_cbox_KeyPress);
            // 
            // sicil_fltr_lbl
            // 
            this.sicil_fltr_lbl.AutoSize = true;
            this.sicil_fltr_lbl.Location = new System.Drawing.Point(310, 28);
            this.sicil_fltr_lbl.Name = "sicil_fltr_lbl";
            this.sicil_fltr_lbl.Size = new System.Drawing.Size(55, 13);
            this.sicil_fltr_lbl.TabIndex = 23;
            this.sicil_fltr_lbl.Text = "SİCİL NO:";
            // 
            // sicil_fltr_cbox
            // 
            this.sicil_fltr_cbox.Location = new System.Drawing.Point(366, 21);
            this.sicil_fltr_cbox.Name = "sicil_fltr_cbox";
            this.sicil_fltr_cbox.Size = new System.Drawing.Size(121, 20);
            this.sicil_fltr_cbox.TabIndex = 2;
            this.sicil_fltr_cbox.TextChanged += new System.EventHandler(this.sicil_fltr_cbox_TextChanged);
            this.sicil_fltr_cbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sicil_fltr_cbox_KeyDown);
            this.sicil_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sicil_fltr_cbox_KeyPress);
            // 
            // blm_fltr_lbl
            // 
            this.blm_fltr_lbl.AutoSize = true;
            this.blm_fltr_lbl.Location = new System.Drawing.Point(310, 53);
            this.blm_fltr_lbl.Name = "blm_fltr_lbl";
            this.blm_fltr_lbl.Size = new System.Drawing.Size(48, 13);
            this.blm_fltr_lbl.TabIndex = 29;
            this.blm_fltr_lbl.Text = "BÖLÜM:";
            // 
            // firma_fltr_cbox
            // 
            this.firma_fltr_cbox.FormattingEnabled = true;
            this.firma_fltr_cbox.Items.AddRange(new object[] {
            ""});
            this.firma_fltr_cbox.Location = new System.Drawing.Point(644, 44);
            this.firma_fltr_cbox.Name = "firma_fltr_cbox";
            this.firma_fltr_cbox.Size = new System.Drawing.Size(121, 21);
            this.firma_fltr_cbox.TabIndex = 5;
            this.firma_fltr_cbox.SelectedIndexChanged += new System.EventHandler(this.firma_fltr_cbox_SelectedIndexChanged);
            this.firma_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firma_fltr_cbox_KeyPress);
            // 
            // brm_fltr_cbox
            // 
            this.brm_fltr_cbox.FormattingEnabled = true;
            this.brm_fltr_cbox.Items.AddRange(new object[] {
            ""});
            this.brm_fltr_cbox.Location = new System.Drawing.Point(644, 16);
            this.brm_fltr_cbox.Name = "brm_fltr_cbox";
            this.brm_fltr_cbox.Size = new System.Drawing.Size(121, 21);
            this.brm_fltr_cbox.TabIndex = 4;
            this.brm_fltr_cbox.SelectedIndexChanged += new System.EventHandler(this.brm_fltr_cbox_SelectedIndexChanged);
            this.brm_fltr_cbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brm_fltr_cbox_KeyPress);
            // 
            // brm_fltr_lbl
            // 
            this.brm_fltr_lbl.AutoSize = true;
            this.brm_fltr_lbl.Location = new System.Drawing.Point(588, 24);
            this.brm_fltr_lbl.Name = "brm_fltr_lbl";
            this.brm_fltr_lbl.Size = new System.Drawing.Size(40, 13);
            this.brm_fltr_lbl.TabIndex = 31;
            this.brm_fltr_lbl.Text = "BİRİM:";
            // 
            // firma_fltr_lbl
            // 
            this.firma_fltr_lbl.AutoSize = true;
            this.firma_fltr_lbl.Location = new System.Drawing.Point(588, 52);
            this.firma_fltr_lbl.Name = "firma_fltr_lbl";
            this.firma_fltr_lbl.Size = new System.Drawing.Size(43, 13);
            this.firma_fltr_lbl.TabIndex = 34;
            this.firma_fltr_lbl.Text = "FİRMA:";
            // 
            // kayıt_gbox
            // 
            this.kayıt_gbox.Controls.Add(this.dataGridView1);
            this.kayıt_gbox.Location = new System.Drawing.Point(291, 115);
            this.kayıt_gbox.Name = "kayıt_gbox";
            this.kayıt_gbox.Size = new System.Drawing.Size(1601, 915);
            this.kayıt_gbox.TabIndex = 5;
            this.kayıt_gbox.TabStop = false;
            this.kayıt_gbox.Text = "KAYIT";
            // 
            // alfapersonelBindingSource5
            // 
            this.alfapersonelBindingSource5.DataMember = "alfa_personel";
            this.alfapersonelBindingSource5.DataSource = this.personel_alfaDataSet7;
            // 
            // personel_alfaDataSet7
            // 
            this.personel_alfaDataSet7.DataSetName = "personel_alfaDataSet7";
            this.personel_alfaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource4
            // 
            this.alfapersonelBindingSource4.DataMember = "alfa_personel";
            this.alfapersonelBindingSource4.DataSource = this.personel_alfaDataSet6;
            // 
            // personel_alfaDataSet6
            // 
            this.personel_alfaDataSet6.DataSetName = "personel_alfaDataSet6";
            this.personel_alfaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource3
            // 
            this.alfapersonelBindingSource3.DataMember = "alfa_personel";
            this.alfapersonelBindingSource3.DataSource = this.personel_alfaDataSet5;
            // 
            // personel_alfaDataSet5
            // 
            this.personel_alfaDataSet5.DataSetName = "personel_alfaDataSet5";
            this.personel_alfaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource2
            // 
            this.alfapersonelBindingSource2.DataMember = "alfa_personel";
            this.alfapersonelBindingSource2.DataSource = this.personel_alfaDataSet4;
            // 
            // personel_alfaDataSet4
            // 
            this.personel_alfaDataSet4.DataSetName = "personel_alfaDataSet4";
            this.personel_alfaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource1
            // 
            this.alfapersonelBindingSource1.DataMember = "alfa_personel";
            this.alfapersonelBindingSource1.DataSource = this.personel_alfaDataSet3;
            // 
            // personel_alfaDataSet3
            // 
            this.personel_alfaDataSet3.DataSetName = "personel_alfaDataSet3";
            this.personel_alfaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource
            // 
            this.alfapersonelBindingSource.DataMember = "alfa_personel";
            this.alfapersonelBindingSource.DataSource = this.personel_alfaDataSet2;
            // 
            // personel_alfaDataSet2
            // 
            this.personel_alfaDataSet2.DataSetName = "personel_alfaDataSet2";
            this.personel_alfaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelalfaBindingSource1
            // 
            this.personelalfaBindingSource1.DataMember = "personel_alfa";
            this.personelalfaBindingSource1.DataSource = this.personel_alfaDataSet1;
            // 
            // personel_alfaDataSet1
            // 
            this.personel_alfaDataSet1.DataSetName = "personel_alfaDataSet1";
            this.personel_alfaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.personelDataSet;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "personelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // personel_alfaDataSet
            // 
            this.personel_alfaDataSet.DataSetName = "personel_alfaDataSet";
            this.personel_alfaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelalfaBindingSource
            // 
            this.personelalfaBindingSource.DataMember = "personel_alfa";
            this.personelalfaBindingSource.DataSource = this.personel_alfaDataSet;
            // 
            // personel_alfaTableAdapter
            // 
            this.personel_alfaTableAdapter.ClearBeforeFill = true;
            // 
            // personel_alfaTableAdapter1
            // 
            this.personel_alfaTableAdapter1.ClearBeforeFill = true;
            // 
            // çıktı_gbox
            // 
            this.çıktı_gbox.Controls.Add(this.excel_çıktı_btn);
            this.çıktı_gbox.Location = new System.Drawing.Point(1706, 12);
            this.çıktı_gbox.Name = "çıktı_gbox";
            this.çıktı_gbox.Size = new System.Drawing.Size(186, 95);
            this.çıktı_gbox.TabIndex = 32;
            this.çıktı_gbox.TabStop = false;
            this.çıktı_gbox.Text = "ÇIKTI";
            // 
            // excel_çıktı_btn
            // 
            this.excel_çıktı_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.excel_çıktı_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.excel_çıktı_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excel_çıktı_btn.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.excel_çıktı_btn.ImageKey = "ms-excel-icon-2048x2026-nws24wyy.png";
            this.excel_çıktı_btn.ImageList = this.ımageList1;
            this.excel_çıktı_btn.Location = new System.Drawing.Point(18, 16);
            this.excel_çıktı_btn.Name = "excel_çıktı_btn";
            this.excel_çıktı_btn.Size = new System.Drawing.Size(73, 73);
            this.excel_çıktı_btn.TabIndex = 0;
            this.excel_çıktı_btn.UseVisualStyleBackColor = false;
            this.excel_çıktı_btn.Click += new System.EventHandler(this.excel_çıktı_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ms-excel-icon-2048x2026-nws24wyy.png");
            // 
            // alfa_personelTableAdapter
            // 
            this.alfa_personelTableAdapter.ClearBeforeFill = true;
            // 
            // alfa_personelTableAdapter1
            // 
            this.alfa_personelTableAdapter1.ClearBeforeFill = true;
            // 
            // alfa_personelTableAdapter2
            // 
            this.alfa_personelTableAdapter2.ClearBeforeFill = true;
            // 
            // alfa_personelTableAdapter3
            // 
            this.alfa_personelTableAdapter3.ClearBeforeFill = true;
            // 
            // alfa_personelTableAdapter4
            // 
            this.alfa_personelTableAdapter4.ClearBeforeFill = true;
            // 
            // alfa_personelTableAdapter5
            // 
            this.alfa_personelTableAdapter5.ClearBeforeFill = true;
            // 
            // personel_alfaDataSet8
            // 
            this.personel_alfaDataSet8.DataSetName = "personel_alfaDataSet8";
            this.personel_alfaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource6
            // 
            this.alfapersonelBindingSource6.DataMember = "alfa_personel";
            this.alfapersonelBindingSource6.DataSource = this.personel_alfaDataSet8;
            // 
            // alfa_personelTableAdapter6
            // 
            this.alfa_personelTableAdapter6.ClearBeforeFill = true;
            // 
            // personel_alfaDataSet9
            // 
            this.personel_alfaDataSet9.DataSetName = "personel_alfaDataSet9";
            this.personel_alfaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource7
            // 
            this.alfapersonelBindingSource7.DataMember = "alfa_personel";
            this.alfapersonelBindingSource7.DataSource = this.personel_alfaDataSet9;
            // 
            // alfa_personelTableAdapter7
            // 
            this.alfa_personelTableAdapter7.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sıraNoDataGridViewTextBoxColumn,
            this.sicilNoDataGridViewTextBoxColumn,
            this.personelAdıDataGridViewTextBoxColumn,
            this.personelSoyadıDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.acilTelDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.bırımDataGridViewTextBoxColumn,
            this.fırmaDataGridViewTextBoxColumn,
            this.grupDataGridViewTextBoxColumn,
            this.gorevDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alfapersonelBindingSource8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1595, 896);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sıraNoDataGridViewTextBoxColumn
            // 
            this.sıraNoDataGridViewTextBoxColumn.DataPropertyName = "Sıra_No";
            this.sıraNoDataGridViewTextBoxColumn.HeaderText = "Sıra_No";
            this.sıraNoDataGridViewTextBoxColumn.Name = "sıraNoDataGridViewTextBoxColumn";
            this.sıraNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sicilNoDataGridViewTextBoxColumn
            // 
            this.sicilNoDataGridViewTextBoxColumn.DataPropertyName = "Sicil_No";
            this.sicilNoDataGridViewTextBoxColumn.HeaderText = "Sicil_No";
            this.sicilNoDataGridViewTextBoxColumn.Name = "sicilNoDataGridViewTextBoxColumn";
            // 
            // personelAdıDataGridViewTextBoxColumn
            // 
            this.personelAdıDataGridViewTextBoxColumn.DataPropertyName = "Personel_Adı";
            this.personelAdıDataGridViewTextBoxColumn.HeaderText = "Personel_Adı";
            this.personelAdıDataGridViewTextBoxColumn.Name = "personelAdıDataGridViewTextBoxColumn";
            // 
            // personelSoyadıDataGridViewTextBoxColumn
            // 
            this.personelSoyadıDataGridViewTextBoxColumn.DataPropertyName = "Personel_Soyadı";
            this.personelSoyadıDataGridViewTextBoxColumn.HeaderText = "Personel_Soyadı";
            this.personelSoyadıDataGridViewTextBoxColumn.Name = "personelSoyadıDataGridViewTextBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // acilTelDataGridViewTextBoxColumn
            // 
            this.acilTelDataGridViewTextBoxColumn.DataPropertyName = "Acil_Tel";
            this.acilTelDataGridViewTextBoxColumn.HeaderText = "Acil_Tel";
            this.acilTelDataGridViewTextBoxColumn.Name = "acilTelDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // bırımDataGridViewTextBoxColumn
            // 
            this.bırımDataGridViewTextBoxColumn.DataPropertyName = "Bırım";
            this.bırımDataGridViewTextBoxColumn.HeaderText = "Bırım";
            this.bırımDataGridViewTextBoxColumn.Name = "bırımDataGridViewTextBoxColumn";
            // 
            // fırmaDataGridViewTextBoxColumn
            // 
            this.fırmaDataGridViewTextBoxColumn.DataPropertyName = "Fırma";
            this.fırmaDataGridViewTextBoxColumn.HeaderText = "Fırma";
            this.fırmaDataGridViewTextBoxColumn.Name = "fırmaDataGridViewTextBoxColumn";
            // 
            // grupDataGridViewTextBoxColumn
            // 
            this.grupDataGridViewTextBoxColumn.DataPropertyName = "Grup";
            this.grupDataGridViewTextBoxColumn.HeaderText = "Grup";
            this.grupDataGridViewTextBoxColumn.Name = "grupDataGridViewTextBoxColumn";
            // 
            // gorevDataGridViewTextBoxColumn
            // 
            this.gorevDataGridViewTextBoxColumn.DataPropertyName = "Gorev";
            this.gorevDataGridViewTextBoxColumn.HeaderText = "Gorev";
            this.gorevDataGridViewTextBoxColumn.Name = "gorevDataGridViewTextBoxColumn";
            // 
            // personel_alfaDataSet10
            // 
            this.personel_alfaDataSet10.DataSetName = "personel_alfaDataSet10";
            this.personel_alfaDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alfapersonelBindingSource8
            // 
            this.alfapersonelBindingSource8.DataMember = "alfa_personel";
            this.alfapersonelBindingSource8.DataSource = this.personel_alfaDataSet10;
            // 
            // alfa_personelTableAdapter8
            // 
            this.alfa_personelTableAdapter8.ClearBeforeFill = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.çıktı_gbox);
            this.Controls.Add(this.kayıt_gbox);
            this.Controls.Add(this.filtre_gbox);
            this.Controls.Add(this.Personel_Bilgi_GBOX);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Bilgi Fornu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);
            this.Personel_Bilgi_GBOX.ResumeLayout(false);
            this.Personel_Bilgi_GBOX.PerformLayout();
            this.filtre_gbox.ResumeLayout(false);
            this.filtre_gbox.PerformLayout();
            this.kayıt_gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelalfaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelalfaBindingSource)).EndInit();
            this.çıktı_gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_alfaDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alfapersonelBindingSource8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Personel_Bilgi_GBOX;
        private System.Windows.Forms.ComboBox bolum_txt;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button listele_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button temizle_btn;
        private System.Windows.Forms.Label bölüm_lbl;
        private System.Windows.Forms.TextBox acil_tel_txt;
        private System.Windows.Forms.Label acil_tel_lbl;
        private System.Windows.Forms.TextBox tel_txt;
        private System.Windows.Forms.Label telefon_lbl;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.Label tc_lbl;
        private System.Windows.Forms.TextBox soyad_txt;
        private System.Windows.Forms.Label soyad_lbl;
        private System.Windows.Forms.TextBox ad_txt;
        private System.Windows.Forms.Label ad_lbl;
        private System.Windows.Forms.TextBox personel_txt;
        private System.Windows.Forms.Label Personel_No_lbl;
        private System.Windows.Forms.GroupBox filtre_gbox;
        private System.Windows.Forms.GroupBox kayıt_gbox;
        private personelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private personelDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private personel_alfaDataSet personel_alfaDataSet;
        private System.Windows.Forms.BindingSource personelalfaBindingSource;
        private personel_alfaDataSetTableAdapters.personel_alfaTableAdapter personel_alfaTableAdapter;
        private System.Windows.Forms.TextBox sicil_txt;
        private System.Windows.Forms.Label sicil_lbl;
        private personel_alfaDataSet1 personel_alfaDataSet1;
        private System.Windows.Forms.BindingSource personelalfaBindingSource1;
        private personel_alfaDataSet1TableAdapters.personel_alfaTableAdapter personel_alfaTableAdapter1;
        private System.Windows.Forms.ComboBox blm_fltr_cbox;
        private System.Windows.Forms.Label blm_fltr_lbl;
        private System.Windows.Forms.Label soyad_fltr_lbl;
        private System.Windows.Forms.TextBox ad_fltr_cbox;
        private System.Windows.Forms.Label ad_fltr_lbl;
        private System.Windows.Forms.TextBox sicil_fltr_cbox;
        private System.Windows.Forms.Label sicil_fltr_lbl;
        private System.Windows.Forms.TextBox soyad_fltr_cbox;
        private System.Windows.Forms.GroupBox çıktı_gbox;
        private System.Windows.Forms.Button excel_çıktı_btn;
        private System.Windows.Forms.ImageList ımageList1;
        private personel_alfaDataSet2 personel_alfaDataSet2;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource;
        private personel_alfaDataSet2TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter;
        private personel_alfaDataSet3 personel_alfaDataSet3;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource1;
        private personel_alfaDataSet3TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter1;
        private personel_alfaDataSet4 personel_alfaDataSet4;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource2;
        private personel_alfaDataSet4TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter2;
        private personel_alfaDataSet5 personel_alfaDataSet5;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource3;
        private personel_alfaDataSet5TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter3;
        private System.Windows.Forms.ComboBox birim_txt;
        private System.Windows.Forms.Label birim_lbl;
        private System.Windows.Forms.ComboBox brm_fltr_cbox;
        private System.Windows.Forms.Label brm_fltr_lbl;
        private System.Windows.Forms.ComboBox firma_txt;
        private System.Windows.Forms.Label firma_lbl;
        private System.Windows.Forms.ComboBox grup_txt;
        private System.Windows.Forms.Label grup_lbl;
        private System.Windows.Forms.ComboBox gorev_txt;
        private System.Windows.Forms.Label görev_lbl;
        private System.Windows.Forms.ComboBox görev_fltr_cbox;
        private System.Windows.Forms.Label görev_fltr_lbl;
        private System.Windows.Forms.ComboBox grup_fltr_cbox;
        private System.Windows.Forms.Label grup_fltr_lbl;
        private System.Windows.Forms.ComboBox firma_fltr_cbox;
        private System.Windows.Forms.Label firma_fltr_lbl;
        private personel_alfaDataSet6 personel_alfaDataSet6;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource4;
        private personel_alfaDataSet6TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter4;
        private personel_alfaDataSet7 personel_alfaDataSet7;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource5;
        private personel_alfaDataSet7TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter5;
        private System.Windows.Forms.Button temizle_fltr_btn;
        private personel_alfaDataSet8 personel_alfaDataSet8;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource6;
        private personel_alfaDataSet8TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter6;
        private personel_alfaDataSet9 personel_alfaDataSet9;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource7;
        private personel_alfaDataSet9TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sıraNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acilTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bırımDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fırmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevDataGridViewTextBoxColumn;
        private personel_alfaDataSet10 personel_alfaDataSet10;
        private System.Windows.Forms.BindingSource alfapersonelBindingSource8;
        private personel_alfaDataSet10TableAdapters.alfa_personelTableAdapter alfa_personelTableAdapter8;
    }
}

