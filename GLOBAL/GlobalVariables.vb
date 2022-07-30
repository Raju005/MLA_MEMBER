Imports System.IO
Imports System.Data.SqlClient
Imports System.Data

Module GlobalVariables
    Public gclsconnection As New GlobalClass
    Public gDebtors As String
    Public gCreditors, gDebdesc As String
    Public gserver, gpdf As String
    Public SQL_UserName, SQL_Password, Productkey As String
    Public gdatabase As String
    Public gUserCategory As String
    Public gcompanyname As String
    Public apppath As String
    Public strDataSqlUsr, strDataSqlPwd, strCompany_ID, MyCompanyName As String
    Public SYSDATE As DateTime
    Public strSqlString As String
    Public brows As Boolean
    Public statusconversionbool As Boolean
    Public gfinnyrend As String
    Public gcommit As Boolean = False

    Public gport As String
    Public gdreader As SqlDataReader
    Public computername As String
    Public Printername As String
    Public keyfield As String
    Public PRINTREP As Boolean
    Public gdate As DateTime
    Public gMAINCompanyname, CREDITYN, USERID, PWD, APPID, SUBAPPID, MESSAGE As String
    Public gFinancialEnd As String
    Public gFinancalyearStart As String
    Public gFinancialyearEnd As String
    Public gvoucherdate As String
    Public gUsername, GmoduleName As String
    Public gdataset As New DataSet
    Public gadapter As SqlDataAdapter
    Public M_WhereCondition As String
    Public M_WhereCondition1 As String
    Public M_WhereCondition2 As String
    Public M_WhereCondition3 As String
    Public gSQLString As String
    Public SUBQQ As Boolean
    Public gcommand As SqlCommand
    Public gfstream As FileStream
    Public gtrans As SqlTransaction
    Public vOutfile, vheader, vLine As String
    Public chkdatevalidate, boolchk As Boolean
    Public VFilePath As String
    Public gheader As String
    Public tables As String
    Public GPRINT As Boolean
    Public gCompanyAddress(10) As String
    Public ADDRESS1 As String
    Public BillPrefix As String
    Public strFinancialYearStart, strFinancialYearEnd
    Public gFinancialyearStart As Date = Date.Now
    Public gFinancialYearDateCheck As Boolean = True
    Public gServerDateCheck As Boolean = False
    Public gMaxDateCheck As Boolean = False
    Public categorybool As Boolean
    Public GOLFbool As Boolean
    Public gSQLString1 As String
    Public Search As String
    Public keyfield1 As String
    Public keyfield2 As String
    Public keyfield3 As String
    Public keyfield4 As String
    Public keyfield5 As String
    Public keyfield6 As String
    Public keyfield7 As String
    Public keyfield8 As String
    Public keyfield9 As String
    Public keyfield10 As String
    Public keyfield11 As String
    Public keyfield12 As String
    Public keyfield13 As String
    Public keyfield14 As String
    Public keyfield15 As String
    Public ServerMastbool As Boolean
  

    'prabhakar variables
    Public MdiParentObj As Object
    Public pl As Boolean
    Public pl1, pl2 As Boolean
    Public pldt, pldt1 As Date
    Public bstodt, bsfrdt As Date
    Public gwindowsflag As Boolean
    Public f3check As Boolean
    Public gDebtorsdesc As String
    Public Filewrite As StreamWriter
    Public gstrVoucherPrefix As String
    Public GBL_SERVERTIME, GBL_SERVERTIME_SECONDS As DateTime
    Public sum As Boolean
    Public intRowcount, intPageNo As Int16
    Public strGCompanyDetails(10), strHeader, SLCODEFILE As String
    Public tTip As New ToolTip
    Public gcity, gstate, gpincode, gdatabase1 As String
    Public gcrystal As String
    Public strGCROBillNo As String
    Public strGPANNo, strGTDACC, strGCompAddress(), strGCompPinCode As String
    Public strGRef_No As String
    Public strPnLMonth, strexcelpath As String
    Public dblPnL As Double
    Public strGFromDate, strGToDate As String
    Public intI, intJ As Int16
    Public boolMonthClose As Boolean
    Public Edt1, Edt2 As Date
    Public strCostCenter As String
    Public gBoolCostCenter As Boolean
    Public gMatchingRpt As Boolean
    Public Exp_todt, Exp_Frdt As New Date
    Public GTdsCode, GTdsCodeDesc As String
    Public M_Groupby As String
    Public gDivCode As String
    Public gDivName As String
    Public gSeasion As String
    Public wemp1, wemp2, wemp3 As String
    Public Reportsql As String
    Public fdataset As New DataSet
    Public strOutFile As String
    Public boolYEC As Boolean
    Public strYECMSG As String
    Public gMatch As New DataSet
    Public gMatchAccountcode As New DataSet
    Public itemtypebool As Boolean
    Public itemmasterbool As Boolean
    Public GroupMasterbool As Boolean
    Public Paymentmodebool As Boolean
    Public POSMastbool As Boolean
    Public RateMastbool As Boolean
    Public UOMRelabool As Boolean
    Public StewardMastbool As Boolean
    Public TableMastbool As Boolean
    Public UOMMastbool As Boolean
    Public subpaymentmodebool As Boolean
    Public posdocumentbool As Boolean
    Public printfile As String
    Public gVoucherno As String
    Public gVoucherType As String
    Public gcostcentercode As String
    Public gpartyname As String
    Public gvoucherprefix As String
    Public gCreditorsDesc As String
    Public gDebitors, gDebitorsDesc As String
    Public gDIFF, gtaxcode, gtaxdesc As String
    Public greportstatus As Boolean
    Public crystalreportstatus As String
    Public gCreditDebit As String
    Public gAccountHead As String
    Public gSlCode As String
    Public gAmount As Double
    Public gAdjusted As Boolean
    Public gRowNo As Integer
    Public MatchVisble As Boolean
    Public gAmt, gtdsamt As Double
    Public VpurchaseAmt As Double
    Public GbatchNo As Long
    Public GCroAmt As Double
    Public GcroUser As String
    Public GcroDate As String
    Public GcroVoucherNo As String
    Public MatchTable As DataTable
    Public vrowcnt As Int16
    Public BLNDBLFORMCLICK As Boolean
    Public PageNo As Integer
    Public PageSize As Integer
    Public AccVoucherno As String
    Public AccVoucherType As String
    Public AccAmount As Double
    Dim gAddress(6) As Object
    Public strSqlMatching, strMVoucherNo, strMAccountcode, strMSlcode As String
    Public intM, intT As Integer
    Public strGMonthName As String
    Public strAltKey As String
    Public intKey As Integer
    Public intC, intF, intS As Integer
    Public boolLedger As Boolean
    Public strLedger As String
End Module
