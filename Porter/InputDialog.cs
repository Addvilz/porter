using System.Windows.Forms;
using System;

namespace Porter
{
    static class InputDialog
    {
        public static DialogResult InputBox(string promptText, ref string value, bool validate)
        {
            Form form = new Form();
            TableLayoutPanel tableLayoutPanelPromptPanel = new System.Windows.Forms.TableLayoutPanel();
            Panel panelTop = new System.Windows.Forms.Panel();
            Panel panelPromptContainer = new System.Windows.Forms.Panel();
            Button buttonOK = new System.Windows.Forms.Button();
            Button buttonCancel = new System.Windows.Forms.Button();
            TextBox textBoxinputTextBox = new System.Windows.Forms.TextBox();
            Label labelPromptQuestion = new System.Windows.Forms.Label();
            // 
            // tableLayoutPanelPromptPanel
            // 
            tableLayoutPanelPromptPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            tableLayoutPanelPromptPanel.ColumnCount = 1;
            tableLayoutPanelPromptPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelPromptPanel.Controls.Add(panelTop, 0, 0);
            tableLayoutPanelPromptPanel.Controls.Add(panelPromptContainer, 0, 1);
            tableLayoutPanelPromptPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelPromptPanel.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanelPromptPanel.Name = "tableLayoutPanelPromptPanel";
            tableLayoutPanelPromptPanel.RowCount = 2;
            tableLayoutPanelPromptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            tableLayoutPanelPromptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelPromptPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelPromptPanel.Size = new System.Drawing.Size(550, 160);
            tableLayoutPanelPromptPanel.TabIndex = 4;
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
            panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            panelTop.Location = new System.Drawing.Point(0, 0);
            panelTop.Margin = new System.Windows.Forms.Padding(0);
            panelTop.Name = "panelTop";
            panelTop.Size = new System.Drawing.Size(550, 4);
            panelTop.TabIndex = 2;
            // 
            // panelPromptContainer
            // 
            panelPromptContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            panelPromptContainer.Controls.Add(labelPromptQuestion);
            panelPromptContainer.Controls.Add(textBoxinputTextBox);
            panelPromptContainer.Controls.Add(buttonOK);
            panelPromptContainer.Controls.Add(buttonCancel);
            panelPromptContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelPromptContainer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            panelPromptContainer.Location = new System.Drawing.Point(1, 4);
            panelPromptContainer.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            panelPromptContainer.Name = "panelPromptContainer";
            panelPromptContainer.Size = new System.Drawing.Size(548, 156);
            panelPromptContainer.TabIndex = 0;
            // 
            // buttonOK
            // 
            buttonOK.AutoSize = true;
            buttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            buttonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            buttonOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            buttonOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            buttonOK.Location = new System.Drawing.Point(33, 100);
            buttonOK.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            buttonOK.Name = "buttonOK";
            buttonOK.Padding = new System.Windows.Forms.Padding(1);
            buttonOK.Size = new System.Drawing.Size(87, 27);
            buttonOK.TabIndex = 10;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.DialogResult = DialogResult.OK;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            buttonCancel.Location = new System.Drawing.Point(134, 100);
            buttonCancel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Padding = new System.Windows.Forms.Padding(1);
            buttonCancel.Size = new System.Drawing.Size(87, 27);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.DialogResult = DialogResult.Cancel;
            // 
            // textBoxinputTextBox
            // 
            textBoxinputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            textBoxinputTextBox.Location = new System.Drawing.Point(33, 64);
            textBoxinputTextBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 10);
            textBoxinputTextBox.Name = "textBoxinputTextBox";
            textBoxinputTextBox.Size = new System.Drawing.Size(485, 23);
            textBoxinputTextBox.TabIndex = 11;
            if (validate)
            {
                textBoxinputTextBox.KeyPress += textBoxinputTextBox_KeyPress;
            }
            // 
            // labelPromptQuestion
            // 
            labelPromptQuestion.AutoSize = true;
            labelPromptQuestion.Location = new System.Drawing.Point(30, 35);
            labelPromptQuestion.Margin = new System.Windows.Forms.Padding(30, 30, 3, 10);
            labelPromptQuestion.Name = "labelPromptQuestion";
            labelPromptQuestion.Size = new System.Drawing.Size(60, 16);
            labelPromptQuestion.TabIndex = 12;
            labelPromptQuestion.Text = promptText;
            //
            // form
            //
            form.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.ClientSize = new System.Drawing.Size(550, 160);
            form.Controls.Add(tableLayoutPanelPromptPanel);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Name = "Prompt";
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Text = "Prompt";
            form.TopMost = true;
            form.ResumeLayout(false);
            form.AcceptButton = buttonOK;
            form.CancelButton = buttonCancel;
            form.ShowInTaskbar = false;
            DialogResult dialogResult = form.ShowDialog();
            value = textBoxinputTextBox.Text;
            return dialogResult;
        }

        static void textBoxinputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) == false && e.KeyChar != '_' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

    }
}
