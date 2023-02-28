<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Piccomic = New System.Windows.Forms.PictureBox()
        Me.Lblheading = New System.Windows.Forms.Label()
        Me.Lblgroup = New System.Windows.Forms.Label()
        Me.TxtGroup = New System.Windows.Forms.TextBox()
        Me.Lblreg = New System.Windows.Forms.Label()
        Me.Btncalculate = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadCSE = New System.Windows.Forms.RadioButton()
        Me.RadCA = New System.Windows.Forms.RadioButton()
        Me.RadC = New System.Windows.Forms.RadioButton()
        Me.Lblcostreg = New System.Windows.Forms.Label()
        CType(Me.Piccomic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Piccomic
        '
        Me.Piccomic.Image = Global.Assignment_5.My.Resources.Resources.comic
        Me.Piccomic.Location = New System.Drawing.Point(3, 0)
        Me.Piccomic.Name = "Piccomic"
        Me.Piccomic.Size = New System.Drawing.Size(794, 158)
        Me.Piccomic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Piccomic.TabIndex = 0
        Me.Piccomic.TabStop = False
        '
        'Lblheading
        '
        Me.Lblheading.AutoSize = True
        Me.Lblheading.Font = New System.Drawing.Font("Comic Sans MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblheading.ForeColor = System.Drawing.Color.Red
        Me.Lblheading.Location = New System.Drawing.Point(131, 174)
        Me.Lblheading.Name = "Lblheading"
        Me.Lblheading.Size = New System.Drawing.Size(552, 51)
        Me.Lblheading.TabIndex = 1
        Me.Lblheading.Text = "Comic Convention Registration"
        '
        'Lblgroup
        '
        Me.Lblgroup.AutoSize = True
        Me.Lblgroup.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblgroup.ForeColor = System.Drawing.Color.Red
        Me.Lblgroup.Location = New System.Drawing.Point(281, 229)
        Me.Lblgroup.Name = "Lblgroup"
        Me.Lblgroup.Size = New System.Drawing.Size(127, 30)
        Me.Lblgroup.TabIndex = 2
        Me.Lblgroup.Text = "Group size:"
        '
        'TxtGroup
        '
        Me.TxtGroup.Location = New System.Drawing.Point(447, 236)
        Me.TxtGroup.Name = "TxtGroup"
        Me.TxtGroup.Size = New System.Drawing.Size(71, 20)
        Me.TxtGroup.TabIndex = 3
        '
        'Lblreg
        '
        Me.Lblreg.AutoSize = True
        Me.Lblreg.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblreg.ForeColor = System.Drawing.Color.Red
        Me.Lblreg.Location = New System.Drawing.Point(243, 410)
        Me.Lblreg.Name = "Lblreg"
        Me.Lblreg.Size = New System.Drawing.Size(197, 30)
        Me.Lblreg.TabIndex = 4
        Me.Lblreg.Text = "Registration Cost:"
        Me.Lblreg.Visible = False
        '
        'Btncalculate
        '
        Me.Btncalculate.BackColor = System.Drawing.Color.Aqua
        Me.Btncalculate.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Btncalculate.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncalculate.Location = New System.Drawing.Point(248, 451)
        Me.Btncalculate.Name = "Btncalculate"
        Me.Btncalculate.Size = New System.Drawing.Size(140, 42)
        Me.Btncalculate.TabIndex = 6
        Me.Btncalculate.Text = "Calculate"
        Me.Btncalculate.UseVisualStyleBackColor = False
        '
        'Btnclear
        '
        Me.Btnclear.BackColor = System.Drawing.Color.Aqua
        Me.Btnclear.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.Location = New System.Drawing.Point(465, 451)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(140, 42)
        Me.Btnclear.TabIndex = 7
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Aqua
        Me.GroupBox1.Controls.Add(Me.RadC)
        Me.GroupBox1.Controls.Add(Me.RadCA)
        Me.GroupBox1.Controls.Add(Me.RadCSE)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(163, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 137)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select badge type:"
        '
        'RadCSE
        '
        Me.RadCSE.AutoSize = True
        Me.RadCSE.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadCSE.Location = New System.Drawing.Point(20, 33)
        Me.RadCSE.Name = "RadCSE"
        Me.RadCSE.Size = New System.Drawing.Size(353, 27)
        Me.RadCSE.TabIndex = 0
        Me.RadCSE.Text = "Convention + Superhero Experience($380)"
        Me.RadCSE.UseVisualStyleBackColor = True
        '
        'RadCA
        '
        Me.RadCA.AutoSize = True
        Me.RadCA.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadCA.Location = New System.Drawing.Point(20, 66)
        Me.RadCA.Name = "RadCA"
        Me.RadCA.Size = New System.Drawing.Size(272, 27)
        Me.RadCA.TabIndex = 1
        Me.RadCA.Text = "Convention + Autographs($275)"
        Me.RadCA.UseVisualStyleBackColor = True
        '
        'RadC
        '
        Me.RadC.AutoSize = True
        Me.RadC.Checked = True
        Me.RadC.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadC.Location = New System.Drawing.Point(20, 99)
        Me.RadC.Name = "RadC"
        Me.RadC.Size = New System.Drawing.Size(160, 27)
        Me.RadC.TabIndex = 2
        Me.RadC.TabStop = True
        Me.RadC.Text = "Convention($209)"
        Me.RadC.UseVisualStyleBackColor = True
        '
        'Lblcostreg
        '
        Me.Lblcostreg.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcostreg.ForeColor = System.Drawing.Color.Red
        Me.Lblcostreg.Location = New System.Drawing.Point(476, 413)
        Me.Lblcostreg.Name = "Lblcostreg"
        Me.Lblcostreg.Size = New System.Drawing.Size(117, 27)
        Me.Lblcostreg.TabIndex = 9
        Me.Lblcostreg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 496)
        Me.Controls.Add(Me.Lblcostreg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btncalculate)
        Me.Controls.Add(Me.Lblreg)
        Me.Controls.Add(Me.TxtGroup)
        Me.Controls.Add(Me.Lblgroup)
        Me.Controls.Add(Me.Lblheading)
        Me.Controls.Add(Me.Piccomic)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comic Convention Registration"
        CType(Me.Piccomic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Piccomic As PictureBox
    Friend WithEvents Lblheading As Label
    Friend WithEvents Lblgroup As Label
    Friend WithEvents TxtGroup As TextBox
    Friend WithEvents Lblreg As Label
    Friend WithEvents Btncalculate As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadC As RadioButton
    Friend WithEvents RadCA As RadioButton
    Friend WithEvents RadCSE As RadioButton
    Friend WithEvents Lblcostreg As Label
End Class
