Option Explicit On
Option Strict On

Public Class SetValue

#Region "Properties"

    Property BaseNumber() As Integer
        Get
            Return CInt(Number.EditValue)
        End Get
        Set(ByVal Value As Integer)
            Number.EditValue = Value
        End Set
    End Property

    Property PerLevelNumber() As Integer
        Get
            Return CInt(LevelSpin.EditValue)
        End Get
        Set(ByVal Value As Integer)
            If LevelCheck.CheckState = CheckState.Checked Then
                LevelSpin.EditValue = Value
            End If
        End Set
    End Property

    Property AbilityMod() As String
        Get
            Return AbilityDropdown.Text
        End Get
        Set(ByVal Value As String)
            If AbilityCheck.CheckState = CheckState.Checked Then
                AbilityDropdown.Text = Value
            End If
        End Set
    End Property

    Property TagNumber() As Integer
        Get
            Return CInt(TagSpin.EditValue)
        End Get
        Set(ByVal Value As Integer)
            If TagCheck.CheckState = CheckState.Checked Then
                TagSpin.EditValue = Value
            End If
        End Set
    End Property

    Property TagString() As String
        Get
            Return TagDropdown.Text
        End Get
        Set(ByVal Value As String)
            If TagCheck.CheckState = CheckState.Checked Then
                TagDropdown.Text = Value
            End If
        End Set
    End Property

#End Region

    Public Sub Init()
        AbilityDropdown.Properties.Items.AddRange(Rules.AbilityScores.Abilities)
        TagDropdown.Properties.Items.AddRange(Rules.Lists.UserTags)
    End Sub

#Region "Control Enable and Disabling"

    Private Sub LevelCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelCheck.CheckedChanged
        If LevelCheck.Checked Then
            LevelPlusLabel.Enabled = True
            LevelSpin.Properties.Enabled = True
            LevelLabel.Enabled = True
            LevelSpin.Value = 1
        Else
            LevelPlusLabel.Enabled = False
            LevelSpin.Properties.Enabled = False
            LevelLabel.Enabled = False

            LevelSpin.Value = 0
        End If
    End Sub

    Private Sub TagCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TagCheck.CheckedChanged
        If TagCheck.Checked Then
            TagPlusLabel.Enabled = True
            TagSpin.Enabled = True
            TagLabel1.Enabled = True
            TagLabel2.Enabled = True
            TagDropdown.Enabled = True
            TagSpin.Value = 1
        Else
            TagPlusLabel.Enabled = False
            TagSpin.Enabled = False
            TagLabel1.Enabled = False
            TagLabel2.Enabled = False
            TagDropdown.Enabled = False

            TagSpin.Value = 0
            TagDropdown.SelectedIndex = -1
        End If
    End Sub

    Private Sub AbilityCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbilityCheck.CheckedChanged
        If AbilityCheck.Checked Then
            AbilityPlusLabel.Enabled = True
            AbilityDropdown.Enabled = True
            AbilityLabel.Enabled = True
        Else
            AbilityPlusLabel.Enabled = False
            AbilityDropdown.Enabled = False
            AbilityLabel.Enabled = False

            AbilityDropdown.SelectedIndex = -1
        End If
    End Sub

#End Region

#Region "Validation"

    Shadows Function Validate() As Boolean
        Return General.ValidateForm(Me.Controls, Errors)
    End Function

#End Region

End Class
