Option Explicit On 
Option Strict On

Imports RPGXplorer.Exceptions

Public Class Images

    'this class encapsulates three image lists, one for icons, one for 16x16 and one for 48x48

#Region "Member Variables"

    Private Shared mSmall As New ImageList
    Private Shared mLarge As New ImageList
    Private Shared mIcons As New ImageList
    Private Shared mImages As New Hashtable
    Private Shared mDimmed As New Hashtable

    'catalogue stores image list index cross-referenced with the filename
    Public Shared mSmallCatalogue As New Hashtable
    Private Shared mLargeCatalogue As New Hashtable
    Private Shared mIconCatalogue As New Hashtable

#End Region

#Region "Properties"

    Public Shared ReadOnly Property LargeImages() As ImageList
        Get
            Return mLarge
        End Get
    End Property

    Public Shared ReadOnly Property LargeImageIndex(ByVal Filename As String) As Integer
        Get
            Return CType(mLargeCatalogue(Filename), Integer)
        End Get
    End Property

    Public Shared ReadOnly Property SmallImages() As ImageList
        Get
            Return mSmall
        End Get
    End Property

    Public Shared ReadOnly Property SmallImageIndex(ByVal Filename As String) As Integer
        Get
            Return CType(mSmallCatalogue(Filename), Integer)
        End Get
    End Property

    Public Shared ReadOnly Property Icons() As ImageList
        Get
            Return mIcons
        End Get
    End Property

    Public Shared ReadOnly Property IconImageIndex(ByVal Filename As String) As Integer
        Get
            Return CType(mIconCatalogue(Filename), Integer)
        End Get
    End Property

    Public Shared ReadOnly Property Image(ByVal Filename As String) As Image
        Get
            Return CType(mImages.Item(Filename), Image)
        End Get
    End Property

    Public Shared ReadOnly Property DimmedImage(ByVal Filename As String) As Image
        Get
            Return CType(mDimmed.Item(Filename), Image)
        End Get
    End Property

#End Region

    'load the image list for all popup menus
    Public Shared Sub LoadImages()
        Dim Images() As String
        Dim Filename As String
        Dim Image As IEnumerator
        Dim x As Integer = 0

        Try
            'NOTE - images folder must contain exactly the same list of files for small and large

            'load the small images
            IO.Directory.SetCurrentDirectory(General.BasePath & "Images\SmallImages")
            Images = IO.Directory.GetFiles(".", "*.png")
            Image = Images.GetEnumerator
            mSmall.Images.Clear()
            mSmall.ImageSize = New Drawing.Size(16, 16)
            mSmall.ColorDepth = ColorDepth.Depth32Bit
            x = 0
            While Image.MoveNext
                'add the image to the image list, store the index in the catalogue
                Dim IconFilename As String = Image.Current.ToString().Substring(2)
                Dim SmallIcon As Image = Bitmap.FromFile(IconFilename)
                mSmall.Images.Add(IconFilename, SmallIcon)
                mSmallCatalogue.Add(IconFilename, x)
                x += 1
            End While

            'load the large images
            IO.Directory.SetCurrentDirectory(General.BasePath & "Images\LargeImages")
            Images = IO.Directory.GetFiles(".", "*.png")
            Image = Images.GetEnumerator
            mLarge.Images.Clear()
            mLarge.ImageSize = New Drawing.Size(51, 51)
            mLarge.ColorDepth = ColorDepth.Depth32Bit
            x = 0
            While Image.MoveNext
                'add the image to the image list, store the index in the catalogue
                Dim IconFilename As String = Image.Current.ToString().Substring(2)
                Dim LargeIcon As Image = Bitmap.FromFile(IconFilename)
                mLarge.Images.Add(IconFilename, LargeIcon)
                mLargeCatalogue.Add(IconFilename, x)
                x += 1
            End While

            'simple check to see that the image lists contain the same number of images
            If mSmallCatalogue.Count <> mLargeCatalogue.Count Then Throw New ImageListLoadException

            'load images
            IO.Directory.SetCurrentDirectory(General.BasePath & "Images\LargeImages")
            Images = IO.Directory.GetFiles(".", "*.png")
            Image = Images.GetEnumerator
            While Image.MoveNext
                'add the image to the image list, store the index in the catalogue
                Filename = CType(Image.Current, String).Substring(2)
                mImages.Add(Filename, New Bitmap(Filename))
            End While

            'load dimmed images
            IO.Directory.SetCurrentDirectory(General.BasePath & "Images\Dimmed")
            Images = IO.Directory.GetFiles(".", "*.png")
            Image = Images.GetEnumerator
            While Image.MoveNext
                'add the image to the image list, store the index in the catalogue
                Filename = CType(Image.Current, String).Substring(2)
                mDimmed.Add(Filename, New Bitmap(Filename))
            End While

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

End Class
