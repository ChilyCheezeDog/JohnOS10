﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Public Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("JohnOS10.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html lang=&quot;en&quot;&gt;
        '''  &lt;head&gt;
        '''
        '''    &lt;meta http-equiv=&quot;content-type&quot; content=&quot;text/html; charset=UTF-8&quot;&gt;
        '''    &lt;meta charset=&quot;UTF-8&quot;&gt;
        '''    &lt;meta http-equiv=&quot;X-UA-Compatible&quot; content=&quot;IE=edge&quot;&gt;
        '''    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot;&gt;
        '''    &lt;title&gt;JohnOS Calculator&lt;/title&gt;
        '''    &lt;link href=&quot;css&quot; rel=&quot;stylesheet&quot;&gt;
        '''    &lt;style&gt;
        '''        *,
        '''        *:before,
        '''        *:after {
        '''            margin: 0;
        '''            padding: 0;
        '''            box-sizing: border-box;
        '''     [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property calc() As String
            Get
                Return ResourceManager.GetString("calc", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;body style=&quot;background-color:teal;text-align:center&quot;&gt;
        '''&lt;font size=&quot;5&quot; color=&quot;white&quot; face=&quot;Helvetica, Arial, sans-serif&quot;&gt; &lt;b&gt;
        '''&lt;div id=&quot;clockbox&quot;&gt;&lt;/div&gt;
        '''&lt;/b&gt;&lt;/font&gt;
        '''
        '''&lt;script type=&quot;text/javascript&quot;&gt;
        '''var tday=[&quot;Sunday&quot;,&quot;Monday&quot;,&quot;Tuesday&quot;,&quot;Wednesday&quot;,&quot;Thursday&quot;,&quot;Friday&quot;,&quot;Saturday&quot;];
        '''var tmonth=[&quot;January&quot;,&quot;February&quot;,&quot;March&quot;,&quot;April&quot;,&quot;May&quot;,&quot;June&quot;,&quot;July&quot;,&quot;August&quot;,&quot;September&quot;,&quot;October&quot;,&quot;November&quot;,&quot;December&quot;];
        '''
        '''function GetClock(){
        '''var d=new Date();
        '''var nday=d.getDay(),nmonth=d.getMonth(),ndate=d.getDate(), [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property clock() As String
            Get
                Return ResourceManager.GetString("clock", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property clouds() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("clouds", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property default_wall() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("default_wall", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property gone_fishing() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("gone_fishing", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property internetconnected() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("internetconnected", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property josconnect() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("josconnect", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;html&gt;&lt;head&gt;
        '''&lt;meta http-equiv=&quot;content-type&quot; content=&quot;text/html; charset=windows-1252&quot;&gt;
        '''&lt;title&gt;Moon Phase Calculator&lt;/title&gt;
        '''&lt;meta name=&quot;viewport&quot; content=&quot;width=240&quot;&gt;
        '''&lt;style&gt;
        '''body { margin:0px; width:240px; height:176px; overflow:hidden; }
        '''&lt;/style&gt;
        '''&lt;/head&gt;
        '''&lt;body bgcolor=&quot;black&quot;&gt;
        '''&lt;script language=&quot;JavaScript&quot;&gt;
        '''
        '''// Star Dust - Background with twinkle stars
        '''// This script and many more from :
        '''// http://rainbow.arch.scriptmania.com
        '''
        '''// Insert these lines just after the &lt;BODY&gt; tag .
        '''
        '''//----   C [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property moon() As String
            Get
                Return ResourceManager.GetString("moon", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property msoe_logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("msoe_logo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property nicole() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nicole", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property nointernet() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nointernet", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property nt_server() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nt_server", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property river_sumida() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("river_sumida", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property test() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("test", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        '''&lt;html&gt;
        '''&lt;font face=&quot;Helvetica, Arial, sans-serif&quot;&gt;
        '''&lt;body&gt;
        '''&lt;p id=&quot;demo&quot;&gt;&lt;/p&gt;
        '''&lt;script&gt;
        '''  var x = navigator.userAgent;
        '''  document.getElementById(&quot;demo&quot;).innerHTML = x;
        '''&lt;/script&gt;
        '''&lt;/body&gt;
        '''&lt;/font&gt;
        '''&lt;/html&gt;.
        '''</summary>
        Public ReadOnly Property ua() As String
            Get
                Return ResourceManager.GetString("ua", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property update() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("update", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property win2k() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("win2k", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
