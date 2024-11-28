namespace OddEvenOddEven;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        checkBox1 = new CheckBox();
        chTOTO = new CheckBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(396, 63);
        button1.Name = "button1";
        button1.Size = new Size(211, 199);
        button1.TabIndex = 0;
        button1.UseVisualStyleBackColor = true;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(363, 305);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(83, 19);
        checkBox1.TabIndex = 1;
        checkBox1.Text = "checkBox1";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // chTOTO
        // 
        chTOTO.AutoSize = true;
        chTOTO.Location = new Point(363, 26);
        chTOTO.Name = "chTOTO";
        chTOTO.Size = new Size(53, 19);
        chTOTO.TabIndex = 2;
        chTOTO.Text = "TOTO";
        chTOTO.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(chTOTO);
        Controls.Add(checkBox1);
        Controls.Add(button1);
        Name = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private CheckBox checkBox1;
    private CheckBox chTOTO;
}
