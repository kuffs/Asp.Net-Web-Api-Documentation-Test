Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net.Http.Formatting
Imports System.Web.Http

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        ' Web API configuration and services

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Formatters.JsonFormatter.MediaTypeMappings.Add(
        New RequestHeaderMapping("Accept", "text/html",
                              StringComparison.InvariantCultureIgnoreCase,
                              True, "application/json")
                              )


    End Sub
End Module
