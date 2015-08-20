Public Class Products
    Private _serial_id As Integer
    Private _product As String
    Private _type_prod As String
    Private _description As String
    Private _file_path As String
    Private _price As String
    Private _second_price As String
    Private _third_price As String
    Private _fourth_price As String

    Public Sub New(ByVal serial_id As Integer, ByVal product As String, ByVal type_prod As String, ByVal description As String, ByVal file_path As String, ByVal price As String, ByVal secondprice As String, ByVal thirdprice As String, ByVal fourthprice As String)
        _serial_id = serial_id
        _product = product
        _type_prod = type_prod
        _description = description
        _file_path = file_path
        _price = price
        _second_price = secondprice
        _third_price = thirdprice
        _fourth_price = fourthprice
    End Sub

    Public Property SerialId() As Integer
        Get
            Return _serial_id
        End Get
        Set(ByVal value As Integer)
            _serial_id = value
        End Set
    End Property

    Public Property Product() As String
        Get
            Return _product
        End Get
        Set(ByVal value As String)
            _product = value
        End Set
    End Property

    Public Property TypeProduct() As String
        Get
            Return _type_prod
        End Get
        Set(ByVal value As String)
            _type_prod = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Public Property FilePath() As String
        Get
            Return _file_path
        End Get
        Set(ByVal value As String)
            _file_path = value
        End Set
    End Property

    Public Property Price() As String
        Get
            Return _price
        End Get
        Set(ByVal value As String)
            _price = value
        End Set
    End Property

    Public Property SecondPrice() As String
        Get
            Return _second_price
        End Get
        Set(ByVal value As String)
            _second_price = value
        End Set
    End Property

    Public Property ThirdPrice() As String
        Get
            Return _third_price
        End Get
        Set(ByVal value As String)
            _third_price = value
        End Set
    End Property

    Public Property FourthPrice() As String
        Get
            Return _fourth_price
        End Get
        Set(ByVal value As String)
            _fourth_price = value
        End Set
    End Property

End Class
