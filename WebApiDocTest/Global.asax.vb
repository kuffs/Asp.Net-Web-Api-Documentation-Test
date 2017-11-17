Imports System.Web.Http

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        GlobalConfiguration.Configuration.Formatters.XmlFormatter.UseXmlSerializer = True
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
    End Sub
End Class
