﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1318
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System.Runtime.Serialization

Namespace SalesService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ClientData
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private IdField As Integer
        
        Private NameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                Me.IdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ClientDataUpdate
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private DeleteField As Boolean
        
        Private IdField As Integer
        
        Private IsNewField As Boolean
        
        Private NameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Delete() As Boolean
            Get
                Return Me.DeleteField
            End Get
            Set
                Me.DeleteField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                Me.IdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IsNew() As Boolean
            Get
                Return Me.IsNewField
            End Get
            Set
                Me.IsNewField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ProjectData
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private DescriptionField As String
        
        Private IdField As Integer
        
        Private NameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Description() As String
            Get
                Return Me.DescriptionField
            End Get
            Set
                Me.DescriptionField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                Me.IdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ProjectSummaryData
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private IdField As Integer
        
        Private NameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                Me.IdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://schemas.datacontract.org/2004/07/")>  _
    Partial Public Class ProjectDataUpdate
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject
        
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private ClientIdField As Integer
        
        Private DeleteField As Boolean
        
        Private DescriptionField As String
        
        Private IdField As Integer
        
        Private IsNewField As Boolean
        
        Private NameField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property ClientId() As Integer
            Get
                Return Me.ClientIdField
            End Get
            Set
                Me.ClientIdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Delete() As Boolean
            Get
                Return Me.DeleteField
            End Get
            Set
                Me.DeleteField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Description() As String
            Get
                Return Me.DescriptionField
            End Get
            Set
                Me.DescriptionField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Id() As Integer
            Get
                Return Me.IdField
            End Get
            Set
                Me.IdField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IsNew() As Boolean
            Get
                Return Me.IsNewField
            End Get
            Set
                Me.IsNewField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Name() As String
            Get
                Return Me.NameField
            End Get
            Set
                Me.NameField = value
            End Set
        End Property
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="SalesService.ISalesService")>  _
    Public Interface ISalesService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/Test", ReplyAction:="http://tempuri.org/ISalesService/TestResponse")>  _
        Function Test() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/GetClientList", ReplyAction:="http://tempuri.org/ISalesService/GetClientListResponse")>  _
        Function GetClientList() As SalesService.ClientData()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/UpdateClients", ReplyAction:="http://tempuri.org/ISalesService/UpdateClientsResponse")>  _
        Sub UpdateClients(ByVal clientList() As SalesService.ClientDataUpdate)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/DeleteClient", ReplyAction:="http://tempuri.org/ISalesService/DeleteClientResponse")>  _
        Sub DeleteClient(ByVal clientId As Integer)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/GetProjectList", ReplyAction:="http://tempuri.org/ISalesService/GetProjectListResponse")>  _
        Function GetProjectList(ByVal clientId As Integer) As SalesService.ProjectData()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/GetProject", ReplyAction:="http://tempuri.org/ISalesService/GetProjectResponse")>  _
        Function GetProject(ByVal projectId As Integer) As SalesService.ProjectData
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/GetFullProjectList", ReplyAction:="http://tempuri.org/ISalesService/GetFullProjectListResponse")>  _
        Function GetFullProjectList() As SalesService.ProjectSummaryData()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/UpdateProjects", ReplyAction:="http://tempuri.org/ISalesService/UpdateProjectsResponse")>  _
        Sub UpdateProjects(ByVal projectList() As SalesService.ProjectDataUpdate)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISalesService/DeleteProject", ReplyAction:="http://tempuri.org/ISalesService/DeleteProjectResponse")>  _
        Sub DeleteProject(ByVal projectId As Integer)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Public Interface ISalesServiceChannel
        Inherits SalesService.ISalesService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")>  _
    Partial Public Class SalesServiceClient
        Inherits System.ServiceModel.ClientBase(Of SalesService.ISalesService)
        Implements SalesService.ISalesService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Test() As String Implements SalesService.ISalesService.Test
            Return MyBase.Channel.Test
        End Function
        
        Public Function GetClientList() As SalesService.ClientData() Implements SalesService.ISalesService.GetClientList
            Return MyBase.Channel.GetClientList
        End Function
        
        Public Sub UpdateClients(ByVal clientList() As SalesService.ClientDataUpdate) Implements SalesService.ISalesService.UpdateClients
            MyBase.Channel.UpdateClients(clientList)
        End Sub
        
        Public Sub DeleteClient(ByVal clientId As Integer) Implements SalesService.ISalesService.DeleteClient
            MyBase.Channel.DeleteClient(clientId)
        End Sub
        
        Public Function GetProjectList(ByVal clientId As Integer) As SalesService.ProjectData() Implements SalesService.ISalesService.GetProjectList
            Return MyBase.Channel.GetProjectList(clientId)
        End Function
        
        Public Function GetProject(ByVal projectId As Integer) As SalesService.ProjectData Implements SalesService.ISalesService.GetProject
            Return MyBase.Channel.GetProject(projectId)
        End Function
        
        Public Function GetFullProjectList() As SalesService.ProjectSummaryData() Implements SalesService.ISalesService.GetFullProjectList
            Return MyBase.Channel.GetFullProjectList
        End Function
        
        Public Sub UpdateProjects(ByVal projectList() As SalesService.ProjectDataUpdate) Implements SalesService.ISalesService.UpdateProjects
            MyBase.Channel.UpdateProjects(projectList)
        End Sub
        
        Public Sub DeleteProject(ByVal projectId As Integer) Implements SalesService.ISalesService.DeleteProject
            MyBase.Channel.DeleteProject(projectId)
        End Sub
    End Class
End Namespace