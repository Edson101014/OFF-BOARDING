
Module ModuleAccept
    Dim apdb As New ApprovalDB
    Dim checker As New ClassChecker

    Dim inserthistory As String
    Dim insertNextFlow As String
    Dim updateHistory As String
    Dim statusNextflow As String
    Dim insertchecker As String
    Dim updatechecker As String
    Dim check As Integer




    Public Property SysAdminHeadNameAccept As String = ViewRequest.LabelSysAdminHeadName.Text
    Public Property SysAdminHeadStatAccept As String = ViewRequest.LabelSysAdminHeadApp.Text
    Public Property SysAdminHeadCommentAccept As String = ViewRequest.txtboxSysAdminHead.Text
    Public Property SysAdminHeadDateAccept As String = ViewRequest.LabelDateSysAdminHead.Text










    'Public Sub SupervisorAccept()
    '    IMNameAccept = "Approve"
    '    ViewRequest.LabelIMSuperApp.Text = IMNameAccept
    '    statusNextflow = "Pending"
    '    IMDateAccept = Date.Today
    '    ViewRequest.LabelDateSDGSuper.Text = IMDateAccept
    '    check = 1

    '    inserthistory = "INSERT INTO `sdgsuperhistory` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperDateApprove`,  `SDGSuperComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday,@name, @status, @dateapp, @comment)"
    '    insertDeptHead = "INSERT INTO `sdgdepthead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGDeptStatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '    updateHistory = "UPDATE `historyrequest` SET `SDGSuperName`=@name, `SDGSuperStatus`=@status, `SDGSuperDateApprove`=@dateapp, `SDGSuperComment`=@comment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, IMNameAccept, IMStatAccept, IMDateAccept, IMCommentAccept, inserthistory)

    '    apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertDeptHead)

    '    apdb.updateHistory(IMNameAccept, IMStatAccept, IMDateAccept, IMCommentAccept, updateHistory)



    '    If checker.verfSDGHeadIfEmpty = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `sdghead`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If


    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If


    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnIMSupervisorApp.Visible = False
    '    ViewRequest.btnIMSupervisorReject.Visible = False

    '    ViewRequest.LabelIMSuperApp.Visible = True
    '    ViewRequest.LabelDateSDGSuper.Visible = True

    '    ViewRequest.txtIMSuperComment.Visible = False



    'End Sub



    'Public Sub BDGDeptApp()
    '    BDGStatAccept = "Approve"
    '    ViewRequest.LabelBDGDeptApp.Text = BDGStatAccept
    '    BDGDateAccept = Date.Today
    '    ViewRequest.LabelDateBDGDept.Text = BDGDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `bdgdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptDateApprove`, `BDGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `BDGDeptName`=@name, `BDGDeptStatus`=@status,`BDGDeptDateApprove`=@dateapp, `BDGDeptComment`=@comment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, inserthistory)
    '    apdb.updateHistory(BDGNameAccept, BDGStatAccept, BDGDateAccept, BDGCommentAccept, updateHistory)


    '    If checker.verfBDGIfEmpty = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `BDG`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If


    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If


    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnBDGDeptApp.Visible = False
    '    ViewRequest.btnBDGDeptReject.Visible = False

    '    ViewRequest.LabelBDGDeptApp.Visible = True

    '    ViewRequest.LabelDateBDGDept.Visible = True

    '    ViewRequest.txtboxBDGDept.Visible = False




    'End Sub

    'Public Sub SDGDeptApp()
    '    SDGStatAccept = "Approve"
    '    ViewRequest.LabelSDGDeptApp.Text = SDGStatAccept
    '    SDGDateAccept = Date.Today
    '    ViewRequest.LabelDateSDGDept.Text = SDGDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `SDGdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptDateApprove`, `SDGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `SDGDeptName`=@name, `SDGDeptStatus`=@status,`SDGDeptDateApprove`=@dateapp, `SDGDeptComment`=@comment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, inserthistory)
    '    apdb.updateHistory(SDGNameAccept, SDGStatAccept, SDGDateAccept, SDGCommentAccept, updateHistory)


    '    If checker.verfSDGIfEmpty() = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `sdg`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If


    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If


    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnSDGDeptApp.Visible = False
    '    ViewRequest.btnSDGDeptReject.Visible = False

    '    ViewRequest.LabelSDGDeptApp.Visible = True

    '    ViewRequest.LabelDateSDGDept.Visible = True

    '    ViewRequest.txtboxSDGDept.Visible = False



    'End Sub

    'Public Sub ITOPSDeptApp()
    '    ITOPSStatAccept = "Approve"
    '    ViewRequest.LabelITOPSDeptApp.Text = ITOPSStatAccept
    '    ITOPSDateAccept = Date.Today
    '    ViewRequest.LabelDateITOPSDept.Text = ITOPSDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `ITOPSdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptDateApprove`, `ITOPSDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `ITOPSDeptName`=@name, `ITOPSDeptStatus`=@status,`ITOPSDeptDateApprove`=@dateapp, `ITOPSDeptComment`=@comment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, inserthistory)
    '    apdb.updateHistory(ITOPSNameAccept, ITOPSStatAccept, ITOPSDateAccept, ITOPSCommentAccept, updateHistory)


    '    If checker.verfITOPSIfEmpty() = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `itops`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If

    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If


    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnITOPSDeptApp.Visible = False
    '    ViewRequest.btnITOPSDeptReject.Visible = False

    '    ViewRequest.LabelITOPSDeptApp.Visible = True

    '    ViewRequest.LabelDateITOPSDept.Visible = True

    '    ViewRequest.txtboxITOPSDept.Visible = False

    'End Sub

    'Public Sub PMGDeptApp()
    '    PMGStatAccept = "Approve"
    '    ViewRequest.LabelPMGDeptApp.Text = PMGStatAccept
    '    PMGDateAccept = Date.Today
    '    ViewRequest.LabelDatePMGDept.Text = PMGDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `PMGdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptDateApprove`, `PMGDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `PMGDeptName`=@name, `PMGDeptStatus`=@status,`PMGDeptDateApprove`=@dateapp, `PMGDeptComment`=@comment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, inserthistory)
    '    apdb.updateHistory(PMGNameAccept, PMGStatAccept, PMGDateAccept, PMGCommentAccept, updateHistory)


    '    If checker.verfPMGIfEmpty() = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `pmg`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If


    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If


    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnPMGDeptApp.Visible = False
    '    ViewRequest.btnPMGDeptReject.Visible = False

    '    ViewRequest.LabelPMGDeptApp.Visible = True

    '    ViewRequest.LabelDatePMGDept.Visible = True

    '    ViewRequest.txtboxPMGDept.Visible = False


    'End Sub

    'Public Sub MarketingDeptApp()
    '    MarketingStatAccept = "Approve"
    '    ViewRequest.LabelMARKETDeptApp.Text = MarketingStatAccept
    '    MarketingDateAccept = Date.Today
    '    ViewRequest.LabelDateMarketingDept.Text = MarketingDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `marketingdepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `marketingDeptName`, `marketingDeptStatus`, `marketingDeptDateApprove`, `marketingDeptComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `marketingDeptName`=@name, `marketingDeptStatus`=@status,`marketingDeptDateApprove`=@dateapp, `marketingDeptComment`=@comment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, inserthistory)
    '    apdb.updateHistory(MarketingNameAccept, MarketingStatAccept, MarketingDateAccept, MarketingCommentAccept, updateHistory)


    '    If checker.verfMARKETINGIfEmpty() = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `Marketing`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If


    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If


    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnMARKETDeptApp.Visible = False
    '    ViewRequest.btnMARKETDeptReject.Visible = False

    '    ViewRequest.LabelMARKETDeptApp.Visible = True

    '    ViewRequest.LabelDateMarketingDept.Visible = True

    '    ViewRequest.txtboxMARKETDept.Visible = False

    'End Sub

    'Public Sub FinanceDeptApp()
    '    FinanceStatAccept = "Approve"
    '    ViewRequest.LabelFINANCEDeptApp.Text = FinanceStatAccept
    '    FinanceDateAccept = Date.Today

    '    ViewRequest.LabelDateFinanceDept.Text = FinanceDateAccept
    '    statusNextflow = "Pending"
    '    check = 1


    '    inserthistory = "INSERT INTO `Financedepthistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FinanceDeptName`, `FinanceDeptStatus`, `FinanceDeptDateApprove`, `FinanceDeptComment`, `CashAdvanceCheck`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment, @checkcash)"
    '    updateHistory = "UPDATE `historyrequest` SET `FinanceDeptName`=@name, `FinanceDeptStatus`=@status,`FinanceDeptDateApprove`=@dateapp, `FinanceDeptComment`=@comment, `CashAdvance`=@checkcash, `CashAdvanceCheckBy`=@checkcashby WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"
    '    insertNextFlow = "INSERT INTO `Financegrouphead` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, financeheadStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

    '    apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    apdb.insertFinance(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkCash, inserthistory)
    '    apdb.updateFinance(FinanceNameAccept, FinanceStatAccept, FinanceDateAccept, FinanceCommentAccept, checkCash, FinanceCashAdvanced, updateHistory)


    '    If checker.verfFINANCEIfEmpty() = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `Finance`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If

    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If




    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnFINANCEDeptApp.Visible = False
    '    ViewRequest.btnFINANCEDeptReject.Visible = False
    '    ViewRequest.CheckBoxCash.Enabled = False
    '    ViewRequest.LabelFINANCEDeptApp.Visible = True

    '    ViewRequest.LabelDateFinanceDept.Visible = True

    '    ViewRequest.txtboxFINANCEDept.Visible = False

    'End Sub

    'Public Sub FinanceHeadApp()
    '    FinanceHeadStatAccept = "Approve"
    '    ViewRequest.LabeLFinanceHeadApp.Text = FinanceHeadStatAccept
    '    FinanceHeadDateAccept = Date.Today
    '    ViewRequest.LabelDateFinanceHead.Text = FinanceHeadDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `financeheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadDateApprove`, `FINANCEHeadComment` ) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `FINANCEHEADName`=@name,`FINANCEHEADStatus`=@status,`FINANCEHEADDateApprove`=@dateapp, `FINANCEHEADComment`=@comment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, inserthistory)
    '    apdb.updateHistory(FinanceHeadNameAccept, FinanceHeadStatAccept, FinanceHeadDateAccept, FinanceHeadCommentAccept, updateHistory)

    '    If checker.verfFinanceHeadIfEmpty() = True Then
    '        insertchecker = "UPDATE `checkergroup` SET `Financehead`=@check WHERE empid='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, insertchecker)
    '    End If


    '    If checker.verfGroupIfComplete() = True Then
    '        insertNextFlow = "INSERT INTO `Admingroup` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, adminStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If




    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnFinanceHeadApp.Visible = False
    '    ViewRequest.btnFinanceHeadReject.Visible = False

    '    ViewRequest.LabeLFinanceHeadApp.Visible = True

    '    ViewRequest.LabelDateFinanceHead.Visible = True

    '    ViewRequest.txtboxFinanceHead.Visible = False

    'End Sub

    'Public Sub HRAppInterview()
    '    Dim tablegroup(5) As String
    '    tablegroup(0) = "BDGDepthead"
    '    tablegroup(1) = "sdgsupervisor"
    '    tablegroup(2) = "itopsDepthead"
    '    tablegroup(3) = "pmgDepthead"
    '    tablegroup(4) = "marketingDepthead"
    '    tablegroup(5) = "financeDepthead"
    '    Dim tablestatus(5) As String
    '    tablestatus(0) = "bdgdeptstatus"
    '    tablestatus(1) = "sdgsuperstatus"
    '    tablestatus(2) = "itopsdeptstatus"
    '    tablestatus(3) = "pmgdeptstatus"
    '    tablestatus(4) = "marketingdeptstatus"
    '    tablestatus(5) = "financedeptstatus"

    '    statusNextflow = "Pending"

    '    updateHistory = "UPDATE `historyrequest` SET `InterviewCheck`=@checkinterview, `ExitInterviewBy`=@interview,`ExitInterviewDateApprove`=@dateapp WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    insertchecker = "INSERT INTO `checkergroup`(`empID`) VALUES (@empid)"
    '    apdb.insertchecker(ViewRequest.LabelEmpID.Text, insertchecker)

    '    apdb.updateinterview(checkinterview, HRInterviewName, HRInterviewDate, updateHistory)
    '    For n As Integer = 0 To 5
    '        insertNextFlow = String.Format("INSERT INTO {0}(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, {1}) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)", tablegroup(n), tablestatus(n))
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)

    '    Next
    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnHRApp.Visible = False

    '    ViewRequest.CheckBoxInterview.Checked = False


    'End Sub

    'Public Sub AdminApp()
    '    statusNextflow = "Pending"

    '    inserthistory = "INSERT INTO `admingrouphistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `CompanyIDCheck`, `ToolsCheck`, `CompanyPhoneCheck`, `TelcoCheck`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @compid, @tools, @compphone, @checktelco)"

    '    updateHistory = "UPDATE `historyrequest` SET `CompanyID`=@compid, `Tools`=@tools, `CompanyPhone`=@compphone, `TelcoCheck`=@checktelco WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    insertNextFlow = "INSERT INTO `sysadmin`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `SysAdminstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

    '    apdb.insertAdminhistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, checkID, checktools, checkphone, checkTelco, inserthistory)

    '    apdb.updateAdmin(checkID, checktools, checkphone, checkTelco, updateHistory)

    '    apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)

    '    insertNextFlow = "INSERT INTO `admingrouphead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `adminheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

    '    apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)

    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()

    '    ViewRequest.CheckBoxCompID.Enabled = False

    '    ViewRequest.CheckBoxTools.Enabled = False

    '    ViewRequest.CheckBoxCompPhone.Enabled = False

    '    ViewRequest.CheckBoxTelco.Enabled = False

    'End Sub

    'Public Sub AdminHeadApp()
    '    AdminHeadStatAccept = "Approve"
    '    ViewRequest.LabelAdminHeadApp.Text = AdminHeadStatAccept
    '    AdminHeadDateAccept = Date.Today
    '    ViewRequest.LabelDateAdminHead.Text = AdminHeadDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `admingroupheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadDateApprove`, `AdminHeadComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `AdminHeadName`=@name, `AdminHeadStatus`=@status, `AdminHeadComment`=@comment, `AdminHeadDateApprove`=@dateapp WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    If checker.verfSysAdminIfEmpty() = True Then
    '        insertchecker = "INSERT INTO `checker`(`empID`, `Adminhead`) VALUES (@empid, @check)"
    '        apdb.insertcheckeradmin(ViewRequest.LabelEmpID.Text, check, insertchecker)

    '    Else
    '        updatechecker = "UPDATE `checker` SET `AdminHead`=@check WHERE empID='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, updatechecker)

    '        insertNextFlow = "INSERT INTO `HR` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, HRStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, inserthistory)
    '    apdb.updateHistory(AdminHeadNameAccept, AdminHeadStatAccept, AdminHeadDateAccept, AdminHeadCommentAccept, updateHistory)

    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()

    '    ViewRequest.btnAdminHeadApp.Visible = False
    '    ViewRequest.btnAdminHeadReject.Visible = False

    '    ViewRequest.LabelAdminHeadApp.Visible = True
    '    ViewRequest.LabelAdminHeadComment.Visible = True
    '    ViewRequest.LabelDateAdminHead.Visible = True


    '    ViewRequest.txtboxAdminHead.Visible = False

    'End Sub

    'Public Sub SysAdmin()

    '    statusNextflow = "Pending"

    '    inserthistory = "INSERT INTO `sysadminhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `Laptop`, `EmailDeac`, `ComDeac`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @checklaptop, @checkemail, @checkcom)"
    '    updateHistory = "UPDATE `historyrequest` SET `Laptop`=@checklaptop,`EmailDeact`=@checkemail,`ComDeact`=@checkcom WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"
    '    insertNextFlow = "INSERT INTO `sysadmingrouphead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `Sysadminheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"

    '    If apdb.insertSYSAdminhistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, checklaptop, checkemail, checkcom, inserthistory) Then

    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)

    '        apdb.updateSYSADMIN(checklaptop, checkemail, checkcom, updateHistory)

    '        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '        apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '        ViewRequest.Label3.Select()

    '        ViewRequest.btnSYSAdminApp.Visible = False

    '        ViewRequest.CheckBoxLaptop.Enabled = False
    '        ViewRequest.CheckBoxEmail.Enabled = False
    '        ViewRequest.CheckBoxComputer.Enabled = False

    '    End If

    'End Sub

    'Public Sub SysAdminHead()
    '    SysAdminHeadStatAccept = "Approve"
    '    ViewRequest.LabelSysAdminHeadApp.Text = SysAdminHeadStatAccept
    '    SysAdminHeadDateAccept = Date.Today
    '    ViewRequest.LabelDateSysAdminHead.Text = SysAdminHeadDateAccept
    '    statusNextflow = "Pending"
    '    check = 1

    '    inserthistory = "INSERT INTO `sysadmingroupheadhistory`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `sysAdminHeadName`, `sysAdminHeadStatus`, `sysAdminHeadDateApprove`, `sysAdminHeadComment`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @name, @status, @dateapp, @comment)"
    '    updateHistory = "UPDATE `historyrequest` SET `sysAdminHeadName`=@name, `sysAdminHeadStatus`=@status, `sysAdminHeadComment`=@comment, `sysAdminHeadDateApprove`=@dateapp WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    If checker.verfAdminIfEmpty() = True Then
    '        insertchecker = "INSERT INTO `checker`(`empID`, `sysAdminhead`) VALUES (@empid, @check)"
    '        apdb.insertcheckeradmin(ViewRequest.LabelEmpID.Text, check, insertchecker)

    '    Else
    '        updatechecker = "UPDATE `checker` SET `sysAdminHead`=@check WHERE empID='" & ViewRequest.LabelEmpID.Text & "'"
    '        apdb.updatechecker(check, updatechecker)

    '        insertNextFlow = "INSERT INTO `HR` (`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, HRStatus) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '        apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)
    '    End If

    '    apdb.insertHistory(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, SysAdminHeadNameAccept, SysAdminHeadStatAccept, SysAdminHeadDateAccept, SysAdminHeadCommentAccept, inserthistory)
    '    apdb.updateHistory(SysAdminHeadNameAccept, SysAdminHeadStatAccept, SysAdminHeadDateAccept, SysAdminHeadCommentAccept, updateHistory)

    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()

    '    ViewRequest.btnSysAdminHeadApp.Visible = False
    '    ViewRequest.btnSysAdminHeadReject.Visible = False

    '    ViewRequest.LabelSysAdminHeadApp.Visible = True
    '    ViewRequest.LabelSysAdminHeadComment.Visible = True
    '    ViewRequest.LabelDateSysAdminHead.Visible = True


    '    ViewRequest.txtboxSysAdminHead.Visible = False

    'End Sub

    'Public Sub HRApp()

    '    statusNextflow = "Pending"

    '    updateHistory = "UPDATE `historyrequest` SET `EssActDeact`=@essdeact, `CompanyHealthCard`=@comphealth, `PayrollATM`=@payroll, `OthersCheck`=@others, `OtherComment`=@othercomment WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"
    '    insertNextFlow = "INSERT INTO `hrhead`(`Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `hrheadstatus`) VALUES (@eName, @eID, @dept, @pos, @purpose, @stat, @lastday, @status)"
    '    apdb.updateHRhistory(checkESS, checkHealth, checkPayroll, checkother, othercomment, updateHistory)

    '    apdb.insertNextFlow(ViewRequest.LabelEmpName.Text, ViewRequest.LabelEmpID.Text, ViewRequest.LabelDept.Text, ViewRequest.LabelPos.Text, ViewRequest.LabelPurpose.Text, ViewRequest.LabelStatus.Text, ViewRequest.LabelLastDay.Text, statusNextflow, insertNextFlow)

    '    Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '    apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)

    '    ViewRequest.Label3.Select()
    '    ViewRequest.btnHRApp.Visible = False

    '    ViewRequest.CheckBoxESS.Checked = False
    '    ViewRequest.CheckBoxCompHealth.Checked = False
    '    ViewRequest.CheckBoxPayroll.Checked = False
    '    ViewRequest.CheckBoxOthers.Checked = False

    '    ViewRequest.txtboxOther.Enabled = False
    '    ViewRequest.txtboxOther.Text = ""

    'End Sub



    'Public Sub HRHeadApp()
    '    HRHeadStatAccept = "Approve"
    '    ViewRequest.LabelHRHeadApp.Text = HRHeadStatAccept
    '    HRHeadDateAccept = Date.Today
    '    ViewRequest.LabelDateHRHead.Text = HRHeadDateAccept

    '    updateHistory = "UPDATE `historyrequest` SET `HRHeadName`=@name, `HRHeadStatus`=@status, `HRHeadComment`=@comment, `HRHeadDateApprove`=@dateapp WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"
    '    apdb.updateHistory(HRHeadNameAccept, HRHeadStatAccept, HRHeadCommentAccept, HRHeadDateAccept, updateHistory)
    '    insertNextFlow = "INSERT INTO `completerequest`(`id`, `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDateApprove`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDateApprove`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDateApprove`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDateApprove`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDateApprove`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDateApprove`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDateApprove`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDateApprove`, `CashAdvance`, `CashAdvanceCheckBy`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDateApprove`, `CompanyID`, `Tools`, `CompanyPhone`, `TelcoCheck`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDateApprove`, `Laptop`, `EmailDeact`, `ComDeact`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDateApprove`, `ESSActDeact`, `CompanyHealthCard`, `PayrollATM`, `OthersCheck`, `OtherComment`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDateApprove`) 
    '      SELECT `id`, `Name`, `empID`, `dept`, `position`, `clearPurpose`, `employeeStatus`, `LastDayEmploy`, `BDGDeptName`, `BDGDeptStatus`, `BDGDeptComment`, `BDGDeptDateApprove`, `SDGSuperName`, `SDGSuperStatus`, `SDGSuperComment`, `SDGSuperDateApprove`, `SDGDeptName`, `SDGDeptStatus`, `SDGDeptComment`, `SDGDeptDateApprove`, `ITOPSDeptName`, `ITOPSDeptStatus`, `ITOPSDeptComment`, `ITOPSDeptDateApprove`, `PMGDeptName`, `PMGDeptStatus`, `PMGDeptComment`, `PMGDeptDateApprove`, `MarketingDeptName`, `MarketingDeptStatus`, `MarketingDeptComment`, `MarketingDeptDateApprove`, `FINANCEHeadName`, `FINANCEHeadStatus`, `FINANCEHeadComment`, `FinanceHeadDateApprove`, `FINANCEDeptName`, `FINANCEDeptStatus`, `FINANCEDeptComment`, `FINANCEDeptDateApprove`, `CashAdvance`, `CashAdvanceCheckBy`, `AdminHeadName`, `AdminHeadStatus`, `AdminHeadComment`, `AdminHeadDateApprove`, `CompanyID`, `Tools`, `CompanyPhone`, `TelcoCheck`, `SysAdminHeadName`, `SysAdminHeadStatus`, `SysAdminHeadComment`, `SysAdminHeadDateApprove`, `Laptop`, `EmailDeact`, `ComDeact`, `HRHeadName`, `HRHeadStatus`, `HRHeadComment`, `HRHeadDateApprove`, `ESSActDeact`, `CompanyHealthCard`, `PayrollATM`, `OthersCheck`, `OtherComment`, `InterviewCheck`, `ExitInterviewBy`, `ExitInterviewDateApprove` FROM `historyrequest` WHERE empID = '" & ViewRequest.LabelEmpID.Text & "'"

    '    If checker.verfHRhistory() = True Then


    '        Dim deletedt As String = String.Format("DELETE FROM {0} WHERE empID = @empID", Login.str)
    '        apdb.deleteRequest(ViewRequest.LabelEmpID.Text, deletedt)
    '        ViewRequest.Label3.Select()
    '        ViewRequest.btnHRHeadApp.Visible = False
    '        ViewRequest.btnHRHeadReject.Visible = False

    '        ViewRequest.LabelHRHeadApp.Visible = True
    '        ViewRequest.LabelDateHRHead.Visible = True
    '        ViewRequest.LabelHRHeadComment.Visible = True

    '        ViewRequest.txtboxHRHead.Visible = False
    '        ViewRequest.txtboxHRHead.Text = ""
    '    Else

    '    End If
    'End Sub
End Module
