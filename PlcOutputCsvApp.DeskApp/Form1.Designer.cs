namespace PlcOutputCsvApp.DeskApp
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnectionState = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.btnSaveGride = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.LoadGride = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaskedTextBoxIp = new System.Windows.Forms.MaskedTextBox();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.btnRemoveColumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnectionState
            // 
            this.btnConnectionState.Location = new System.Drawing.Point(12, 21);
            this.btnConnectionState.Name = "btnConnectionState";
            this.btnConnectionState.Size = new System.Drawing.Size(166, 77);
            this.btnConnectionState.TabIndex = 0;
            this.btnConnectionState.Text = "Connection";
            this.btnConnectionState.UseVisualStyleBackColor = true;
            this.btnConnectionState.Click += new System.EventHandler(this.btnConnectionState_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(244, 71);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(179, 36);
            this.textBoxPort.TabIndex = 2;
            // 
            // btnSaveGride
            // 
            this.btnSaveGride.Location = new System.Drawing.Point(12, 134);
            this.btnSaveGride.Name = "btnSaveGride";
            this.btnSaveGride.Size = new System.Drawing.Size(166, 42);
            this.btnSaveGride.TabIndex = 0;
            this.btnSaveGride.Text = "Save Gride";
            this.btnSaveGride.UseVisualStyleBackColor = true;
            this.btnSaveGride.Click += new System.EventHandler(this.btnSaveGride_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(246, 529);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(177, 42);
            this.btnOutput.TabIndex = 0;
            this.btnOutput.Text = "Output *.csv";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // LoadGride
            // 
            this.LoadGride.Location = new System.Drawing.Point(257, 134);
            this.LoadGride.Name = "LoadGride";
            this.LoadGride.Size = new System.Drawing.Size(166, 42);
            this.LoadGride.TabIndex = 0;
            this.LoadGride.Text = "Load Gride";
            this.LoadGride.UseVisualStyleBackColor = true;
            this.LoadGride.Click += new System.EventHandler(this.LoadGride_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 305);
            this.dataGridView1.TabIndex = 3;
            // 
            // MaskedTextBoxIp
            // 
            this.MaskedTextBoxIp.Location = new System.Drawing.Point(244, 18);
            this.MaskedTextBoxIp.Mask = "###.###.###.###";
            this.MaskedTextBoxIp.Name = "MaskedTextBoxIp";
            this.MaskedTextBoxIp.Size = new System.Drawing.Size(179, 36);
            this.MaskedTextBoxIp.TabIndex = 4;
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(429, 195);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(179, 42);
            this.btnAddColumn.TabIndex = 0;
            this.btnAddColumn.Text = "+ Column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // btnRemoveColumn
            // 
            this.btnRemoveColumn.Location = new System.Drawing.Point(429, 243);
            this.btnRemoveColumn.Name = "btnRemoveColumn";
            this.btnRemoveColumn.Size = new System.Drawing.Size(179, 42);
            this.btnRemoveColumn.TabIndex = 0;
            this.btnRemoveColumn.Text = "- Column";
            this.btnRemoveColumn.UseVisualStyleBackColor = true;
            this.btnRemoveColumn.Click += new System.EventHandler(this.btnRemoveColumn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 587);
            this.Controls.Add(this.MaskedTextBoxIp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnRemoveColumn);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.LoadGride);
            this.Controls.Add(this.btnSaveGride);
            this.Controls.Add(this.btnConnectionState);
            this.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "PlcOutputCsvApp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button btnSaveGride;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button LoadGride;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox MaskedTextBoxIp;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.Button btnRemoveColumn;
    }
}

