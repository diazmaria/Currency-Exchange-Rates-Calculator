namespace Currency_Exchange_Rates_Calculator
{
    partial class FormCurrencyExchangeRates
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrencyExchangeRates));
            this.labelCurrentCurrency = new System.Windows.Forms.Label();
            this.LabelNewCurrency = new System.Windows.Forms.Label();
            this.comboBoxCurrentCurrency = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyDBDataSet = new Currency_Exchange_Rates_Calculator.CurrencyDBDataSet();
            this.comboBoxNewCurrency = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelExchangeRate = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.currencyTableAdapter = new Currency_Exchange_Rates_Calculator.CurrencyDBDataSetTableAdapters.CurrencyTableAdapter();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentCurrency
            // 
            this.labelCurrentCurrency.AutoSize = true;
            this.labelCurrentCurrency.Location = new System.Drawing.Point(44, 111);
            this.labelCurrentCurrency.Name = "labelCurrentCurrency";
            this.labelCurrentCurrency.Size = new System.Drawing.Size(127, 21);
            this.labelCurrentCurrency.TabIndex = 0;
            this.labelCurrentCurrency.Text = "Current Currency:";
            // 
            // LabelNewCurrency
            // 
            this.LabelNewCurrency.AutoSize = true;
            this.LabelNewCurrency.Location = new System.Drawing.Point(65, 160);
            this.LabelNewCurrency.Name = "LabelNewCurrency";
            this.LabelNewCurrency.Size = new System.Drawing.Size(106, 21);
            this.LabelNewCurrency.TabIndex = 1;
            this.LabelNewCurrency.Text = "New Currency:";
            // 
            // comboBoxCurrentCurrency
            // 
            this.comboBoxCurrentCurrency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCurrentCurrency.DataSource = this.currencyBindingSource;
            this.comboBoxCurrentCurrency.DisplayMember = "CurrencyName";
            this.comboBoxCurrentCurrency.DropDownHeight = 125;
            this.comboBoxCurrentCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrentCurrency.DropDownWidth = 260;
            this.comboBoxCurrentCurrency.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCurrentCurrency.FormattingEnabled = true;
            this.comboBoxCurrentCurrency.IntegralHeight = false;
            this.comboBoxCurrentCurrency.ItemHeight = 18;
            this.comboBoxCurrentCurrency.Location = new System.Drawing.Point(197, 111);
            this.comboBoxCurrentCurrency.Name = "comboBoxCurrentCurrency";
            this.comboBoxCurrentCurrency.Size = new System.Drawing.Size(266, 26);
            this.comboBoxCurrentCurrency.TabIndex = 0;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.currencyDBDataSet;
            // 
            // currencyDBDataSet
            // 
            this.currencyDBDataSet.DataSetName = "CurrencyDBDataSet";
            this.currencyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxNewCurrency
            // 
            this.comboBoxNewCurrency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNewCurrency.DataSource = this.currencyBindingSource1;
            this.comboBoxNewCurrency.DisplayMember = "CurrencyName";
            this.comboBoxNewCurrency.DropDownHeight = 125;
            this.comboBoxNewCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewCurrency.DropDownWidth = 260;
            this.comboBoxNewCurrency.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNewCurrency.FormattingEnabled = true;
            this.comboBoxNewCurrency.IntegralHeight = false;
            this.comboBoxNewCurrency.Location = new System.Drawing.Point(197, 160);
            this.comboBoxNewCurrency.Name = "comboBoxNewCurrency";
            this.comboBoxNewCurrency.Size = new System.Drawing.Size(266, 26);
            this.comboBoxNewCurrency.TabIndex = 0;
            this.comboBoxNewCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewCurrency_SelectedIndexChanged);
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataMember = "Currency";
            this.currencyBindingSource1.DataSource = this.currencyDBDataSet;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCalculate.Location = new System.Drawing.Point(85, 213);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(82, 30);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelExchangeRate
            // 
            this.labelExchangeRate.AutoSize = true;
            this.labelExchangeRate.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExchangeRate.Location = new System.Drawing.Point(271, 218);
            this.labelExchangeRate.Name = "labelExchangeRate";
            this.labelExchangeRate.Size = new System.Drawing.Size(0, 21);
            this.labelExchangeRate.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.LightBlue;
            this.labelTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(44, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(301, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Currency Exchange Rates Calculator";
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(302, 255);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 21);
            this.labelResult.TabIndex = 6;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCurrencyExchangeRates
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(527, 316);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelExchangeRate);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxNewCurrency);
            this.Controls.Add(this.comboBoxCurrentCurrency);
            this.Controls.Add(this.LabelNewCurrency);
            this.Controls.Add(this.labelCurrentCurrency);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(543, 354);
            this.MinimumSize = new System.Drawing.Size(543, 354);
            this.Name = "FormCurrencyExchangeRates";
            this.Text = "Currency Exchange Rates Calculator";
            this.Load += new System.EventHandler(this.FormCurrencyExchangeRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentCurrency;
        private System.Windows.Forms.Label LabelNewCurrency;
        private System.Windows.Forms.ComboBox comboBoxCurrentCurrency;
        private System.Windows.Forms.ComboBox comboBoxNewCurrency;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelExchangeRate;
        private System.Windows.Forms.Label labelTitle;
        private CurrencyDBDataSet currencyDBDataSet;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private CurrencyDBDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.Label labelResult;
    }
}

