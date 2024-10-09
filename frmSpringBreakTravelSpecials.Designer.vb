<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSpringBreakTravelSpecials
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picMyrtleBeach = New PictureBox()
        btnMrytle = New Button()
        btnWest = New Button()
        btnVenice = New Button()
        btnPurchase = New Button()
        btnExit = New Button()
        picKeyWest = New PictureBox()
        picVeniceBeach = New PictureBox()
        btnSelect = New Button()
        lblInstruction = New Label()
        lblConfirmation = New Label()
        lblHeading = New Label()
        CType(picMyrtleBeach, ComponentModel.ISupportInitialize).BeginInit()
        CType(picKeyWest, ComponentModel.ISupportInitialize).BeginInit()
        CType(picVeniceBeach, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picMyrtleBeach
        ' 
        picMyrtleBeach.Image = My.Resources.Resources.mrytle_beach
        picMyrtleBeach.Location = New Point(68, 35)
        picMyrtleBeach.Name = "picMyrtleBeach"
        picMyrtleBeach.Size = New Size(260, 200)
        picMyrtleBeach.SizeMode = PictureBoxSizeMode.StretchImage
        picMyrtleBeach.TabIndex = 0
        picMyrtleBeach.TabStop = False
        picMyrtleBeach.Visible = False
        ' 
        ' btnMrytle
        ' 
        btnMrytle.BackColor = Color.CornflowerBlue
        btnMrytle.Font = New Font("Tahoma", 9F)
        btnMrytle.Location = New Point(109, 257)
        btnMrytle.Name = "btnMrytle"
        btnMrytle.Size = New Size(120, 23)
        btnMrytle.TabIndex = 2
        btnMrytle.Text = "Mrytle Beach"
        btnMrytle.UseVisualStyleBackColor = False
        ' 
        ' btnWest
        ' 
        btnWest.BackColor = Color.CornflowerBlue
        btnWest.Font = New Font("Tahoma", 9F)
        btnWest.Location = New Point(439, 257)
        btnWest.Name = "btnWest"
        btnWest.Size = New Size(120, 23)
        btnWest.TabIndex = 3
        btnWest.Text = "Key West"
        btnWest.UseVisualStyleBackColor = False
        ' 
        ' btnVenice
        ' 
        btnVenice.BackColor = Color.CornflowerBlue
        btnVenice.Font = New Font("Tahoma", 9F)
        btnVenice.Location = New Point(812, 257)
        btnVenice.Name = "btnVenice"
        btnVenice.Size = New Size(120, 23)
        btnVenice.TabIndex = 4
        btnVenice.Text = "Venice Beach"
        btnVenice.UseVisualStyleBackColor = False
        ' 
        ' btnPurchase
        ' 
        btnPurchase.BackColor = Color.WhiteSmoke
        btnPurchase.Enabled = False
        btnPurchase.Font = New Font("Tahoma", 9F)
        btnPurchase.Location = New Point(484, 379)
        btnPurchase.Name = "btnPurchase"
        btnPurchase.Size = New Size(75, 23)
        btnPurchase.TabIndex = 5
        btnPurchase.Text = "Purchase"
        btnPurchase.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.WhiteSmoke
        btnExit.Enabled = False
        btnExit.Font = New Font("Tahoma", 9F)
        btnExit.Location = New Point(456, 456)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(128, 23)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit Window"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' picKeyWest
        ' 
        picKeyWest.Image = My.Resources.Resources.key_west
        picKeyWest.Location = New Point(374, 35)
        picKeyWest.Name = "picKeyWest"
        picKeyWest.Size = New Size(260, 200)
        picKeyWest.SizeMode = PictureBoxSizeMode.StretchImage
        picKeyWest.TabIndex = 7
        picKeyWest.TabStop = False
        picKeyWest.Visible = False
        ' 
        ' picVeniceBeach
        ' 
        picVeniceBeach.Image = My.Resources.Resources.venice_beach
        picVeniceBeach.Location = New Point(712, 35)
        picVeniceBeach.Name = "picVeniceBeach"
        picVeniceBeach.Size = New Size(260, 200)
        picVeniceBeach.SizeMode = PictureBoxSizeMode.StretchImage
        picVeniceBeach.TabIndex = 8
        picVeniceBeach.TabStop = False
        picVeniceBeach.Visible = False
        ' 
        ' btnSelect
        ' 
        btnSelect.BackColor = Color.WhiteSmoke
        btnSelect.Enabled = False
        btnSelect.Font = New Font("Tahoma", 9F)
        btnSelect.Location = New Point(455, 339)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(130, 23)
        btnSelect.TabIndex = 9
        btnSelect.Text = "Select the trip"
        btnSelect.UseVisualStyleBackColor = False
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AutoSize = True
        lblInstruction.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruction.Location = New Point(384, 302)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(269, 16)
        lblInstruction.TabIndex = 10
        lblInstruction.Text = "Choose your favorite trip for the spring break "
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.AutoSize = True
        lblConfirmation.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblConfirmation.Location = New Point(475, 421)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(90, 16)
        lblConfirmation.TabIndex = 11
        lblConfirmation.Text = "Enjoy your trip"
        lblConfirmation.Visible = False
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(446, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(148, 19)
        lblHeading.TabIndex = 12
        lblHeading.Text = "Spring Break Travel"
        ' 
        ' frmSpringBreakTravelSpecials
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1041, 606)
        Controls.Add(lblHeading)
        Controls.Add(lblConfirmation)
        Controls.Add(lblInstruction)
        Controls.Add(btnSelect)
        Controls.Add(picVeniceBeach)
        Controls.Add(picKeyWest)
        Controls.Add(btnExit)
        Controls.Add(btnPurchase)
        Controls.Add(btnVenice)
        Controls.Add(btnWest)
        Controls.Add(btnMrytle)
        Controls.Add(picMyrtleBeach)
        Name = "frmSpringBreakTravelSpecials"
        Text = "Spring Break Travel Specials"
        CType(picMyrtleBeach, ComponentModel.ISupportInitialize).EndInit()
        CType(picKeyWest, ComponentModel.ISupportInitialize).EndInit()
        CType(picVeniceBeach, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picMyrtleBeach As PictureBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents btnMrytle As Button
    Friend WithEvents btnWest As Button
    Friend WithEvents btnVenice As Button
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picKeyWest As PictureBox
    Friend WithEvents picVeniceBeach As PictureBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents lblHeading As Label

End Class
