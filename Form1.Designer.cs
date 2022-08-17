namespace WinFormsAppSerializationExample
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tblFields = new System.Windows.Forms.TableLayoutPanel();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.btnBinarySerialize = new System.Windows.Forms.Button();
            this.btnBinaryDeserialize = new System.Windows.Forms.Button();
            this.btnCreateStudentRecord = new System.Windows.Forms.Button();
            this.btnXMLDeserialize = new System.Windows.Forms.Button();
            this.btnXMLSerialize = new System.Windows.Forms.Button();
            this.btnJSONDeserialize = new System.Windows.Forms.Button();
            this.btnJSONSerialize = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessages = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblFields.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.89899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.10101F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 101);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(247, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 24);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(247, 49);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 24);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(247, 90);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 24);
            this.textBox3.TabIndex = 7;
            // 
            // tblFields
            // 
            this.tblFields.ColumnCount = 2;
            this.tblFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.89899F));
            this.tblFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.10101F));
            this.tblFields.Controls.Add(this.lblStudentID, 0, 0);
            this.tblFields.Controls.Add(this.lblFullName, 0, 1);
            this.tblFields.Controls.Add(this.lblGPA, 0, 2);
            this.tblFields.Controls.Add(this.txtStudentID, 1, 0);
            this.tblFields.Controls.Add(this.txtFullName, 1, 1);
            this.tblFields.Controls.Add(this.txtGPA, 1, 2);
            this.tblFields.Location = new System.Drawing.Point(39, 101);
            this.tblFields.Margin = new System.Windows.Forms.Padding(4);
            this.tblFields.Name = "tblFields";
            this.tblFields.RowCount = 3;
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFields.Size = new System.Drawing.Size(462, 123);
            this.tblFields.TabIndex = 0;
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(55, 12);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(74, 16);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(60, 53);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(64, 16);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // lblGPA
            // 
            this.lblGPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(77, 94);
            this.lblGPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(30, 16);
            this.lblGPA.TabIndex = 4;
            this.lblGPA.Text = "GPA";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStudentID.BackColor = System.Drawing.Color.LightYellow;
            this.txtStudentID.Location = new System.Drawing.Point(215, 8);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(215, 24);
            this.txtStudentID.TabIndex = 5;
            this.txtStudentID.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentID_Validating);
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFullName.BackColor = System.Drawing.Color.LightYellow;
            this.txtFullName.Location = new System.Drawing.Point(215, 49);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(215, 24);
            this.txtFullName.TabIndex = 6;
            // 
            // txtGPA
            // 
            this.txtGPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGPA.BackColor = System.Drawing.Color.LightYellow;
            this.txtGPA.Location = new System.Drawing.Point(215, 90);
            this.txtGPA.Margin = new System.Windows.Forms.Padding(4);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(215, 24);
            this.txtGPA.TabIndex = 7;
            this.txtGPA.Validating += new System.ComponentModel.CancelEventHandler(this.txtGPA_Validating);
            // 
            // btnBinarySerialize
            // 
            this.btnBinarySerialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBinarySerialize.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnBinarySerialize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBinarySerialize.Location = new System.Drawing.Point(46, 8);
            this.btnBinarySerialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnBinarySerialize.Name = "btnBinarySerialize";
            this.btnBinarySerialize.Size = new System.Drawing.Size(138, 32);
            this.btnBinarySerialize.TabIndex = 1;
            this.btnBinarySerialize.Text = "Binary Serialize";
            this.btnBinarySerialize.UseVisualStyleBackColor = false;
            this.btnBinarySerialize.Click += new System.EventHandler(this.btnBinarySerialize_Click);
            // 
            // btnBinaryDeserialize
            // 
            this.btnBinaryDeserialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBinaryDeserialize.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnBinaryDeserialize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBinaryDeserialize.Location = new System.Drawing.Point(277, 8);
            this.btnBinaryDeserialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnBinaryDeserialize.Name = "btnBinaryDeserialize";
            this.btnBinaryDeserialize.Size = new System.Drawing.Size(138, 32);
            this.btnBinaryDeserialize.TabIndex = 2;
            this.btnBinaryDeserialize.Text = "Binary Deserialize";
            this.btnBinaryDeserialize.UseVisualStyleBackColor = false;
            this.btnBinaryDeserialize.Click += new System.EventHandler(this.btnBinaryDeserialize_Click);
            // 
            // btnCreateStudentRecord
            // 
            this.btnCreateStudentRecord.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCreateStudentRecord.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateStudentRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreateStudentRecord.Location = new System.Drawing.Point(149, 232);
            this.btnCreateStudentRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateStudentRecord.Name = "btnCreateStudentRecord";
            this.btnCreateStudentRecord.Size = new System.Drawing.Size(243, 29);
            this.btnCreateStudentRecord.TabIndex = 3;
            this.btnCreateStudentRecord.Text = "Create Student Record";
            this.btnCreateStudentRecord.UseVisualStyleBackColor = false;
            this.btnCreateStudentRecord.Click += new System.EventHandler(this.btnCreateStudentRecord_Click);
            // 
            // btnXMLDeserialize
            // 
            this.btnXMLDeserialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXMLDeserialize.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnXMLDeserialize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXMLDeserialize.Location = new System.Drawing.Point(277, 57);
            this.btnXMLDeserialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnXMLDeserialize.Name = "btnXMLDeserialize";
            this.btnXMLDeserialize.Size = new System.Drawing.Size(138, 32);
            this.btnXMLDeserialize.TabIndex = 5;
            this.btnXMLDeserialize.Text = "XML Deserialize";
            this.btnXMLDeserialize.UseVisualStyleBackColor = false;
            this.btnXMLDeserialize.Click += new System.EventHandler(this.btnXMLDeserialize_Click);
            // 
            // btnXMLSerialize
            // 
            this.btnXMLSerialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXMLSerialize.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnXMLSerialize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXMLSerialize.Location = new System.Drawing.Point(46, 57);
            this.btnXMLSerialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnXMLSerialize.Name = "btnXMLSerialize";
            this.btnXMLSerialize.Size = new System.Drawing.Size(138, 32);
            this.btnXMLSerialize.TabIndex = 4;
            this.btnXMLSerialize.Text = "XML Serialize";
            this.btnXMLSerialize.UseVisualStyleBackColor = false;
            this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
            // 
            // btnJSONDeserialize
            // 
            this.btnJSONDeserialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJSONDeserialize.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnJSONDeserialize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnJSONDeserialize.Location = new System.Drawing.Point(277, 106);
            this.btnJSONDeserialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnJSONDeserialize.Name = "btnJSONDeserialize";
            this.btnJSONDeserialize.Size = new System.Drawing.Size(138, 32);
            this.btnJSONDeserialize.TabIndex = 7;
            this.btnJSONDeserialize.Text = "JSON Deserialize";
            this.btnJSONDeserialize.UseVisualStyleBackColor = false;
            this.btnJSONDeserialize.Click += new System.EventHandler(this.btnJSONDeserialize_Click);
            // 
            // btnJSONSerialize
            // 
            this.btnJSONSerialize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJSONSerialize.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnJSONSerialize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnJSONSerialize.Location = new System.Drawing.Point(46, 106);
            this.btnJSONSerialize.Margin = new System.Windows.Forms.Padding(4);
            this.btnJSONSerialize.Name = "btnJSONSerialize";
            this.btnJSONSerialize.Size = new System.Drawing.Size(138, 32);
            this.btnJSONSerialize.TabIndex = 6;
            this.btnJSONSerialize.Text = "JSON Serialize";
            this.btnJSONSerialize.UseVisualStyleBackColor = false;
            this.btnJSONSerialize.Click += new System.EventHandler(this.btnJSONSerialize_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBinarySerialize, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnJSONDeserialize, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnXMLDeserialize, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBinaryDeserialize, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnJSONSerialize, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnXMLSerialize, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 285);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(462, 147);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessages.ForeColor = System.Drawing.Color.Red;
            this.lblMessages.Location = new System.Drawing.Point(39, 38);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(107, 19);
            this.lblMessages.TabIndex = 9;
            this.lblMessages.Text = "No messages";
            this.lblMessages.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(547, 452);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnCreateStudentRecord);
            this.Controls.Add(this.tblFields);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Student Data Serializer/Deserializer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblFields.ResumeLayout(false);
            this.tblFields.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TableLayoutPanel tblFields;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Button btnBinarySerialize;
        private System.Windows.Forms.Button btnBinaryDeserialize;
        private System.Windows.Forms.Button btnCreateStudentRecord;
        private System.Windows.Forms.Button btnXMLDeserialize;
        private System.Windows.Forms.Button btnXMLSerialize;
        private System.Windows.Forms.Button btnJSONDeserialize;
        private System.Windows.Forms.Button btnJSONSerialize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMessages;
    }
}

