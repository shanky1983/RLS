-----------For Role Table-----------------------------------------------------------------------------

Drop table TempRole
Create table TempRole(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempRole Select 'Lab Technician','Nombre'
Insert into TempRole Select'Administrator','Técnico de laboratorio'
Insert into TempRole Select'Lab Reception','Administrador'
Insert into TempRole Select'Sr Lab Technician','La recepción de laboratorio'
Insert into TempRole Select'Phlebotomist','Técnico de laboratorio sr'
Insert into TempRole Select'Pathologist','flebotomista'
Insert into TempRole Select'Credit Controller','Patólogo'
Insert into TempRole Select'Accession','Controlador de crédito'
Insert into TempRole Select'Dispatch Controller','Adhesión'

alter table Role
drop constraint PK_Role

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into Role (RoleID  ,RoleName   ,Description,OrgID ,LangCode  )
select distinct R.RoleID  ,R.RoleName ,tbl.ChineseChar ,@OrgiD ,@language from Role R
inner join TempRole tbl on tbl.Name =R.Description  and OrgID =@OrgiD 
where OrgID =@OrgiD 
---------------------------------------------------------------------------------------------------------
----------------For ActionMaste Table--------------------------------------------------------------------
drop table TempActionMaster
Create table TempActionMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000),ActionID int)  

Insert into TempActionMaster Select'Generate New Bill','Generar nuevo proyecto de ley',1
Insert into TempActionMaster Select'Approve Order','aprobar Orden',2
Insert into TempActionMaster Select'Book / Transfer Room','Libro / Transferencia de habitaciones',3
Insert into TempActionMaster Select'Change Priority','Cambiar prioridad',4
Insert into TempActionMaster Select'Clear Dues','Las cuotas claras',5
Insert into TempActionMaster Select'Collect Advance','recoger Avance',6
Insert into TempActionMaster Select'Collect Consultation Fees','Recoger honorarios de consulta',7
Insert into TempActionMaster Select'Collect Due Payment','Recoger Debido Pago',8
Insert into TempActionMaster Select'Collect Sample','recoger la Muestra',9
Insert into TempActionMaster Select'Collect Surgery Advance','Recoger Avance Cirugía',10
Insert into TempActionMaster Select'Collect Vitals','recoger vitales',11
Insert into TempActionMaster Select'Dialysis Case Sheet','Hoja de diálisis Caso',12
Insert into TempActionMaster Select'Discharge Summary','Resumen de alta',13
Insert into TempActionMaster Select'Drugs Administered','Los fármacos administrados',14
Insert into TempActionMaster Select'Due Collection','debido Colección',15
Insert into TempActionMaster Select'Due Payment Collect','Debido Pago Collect',16
Insert into TempActionMaster Select'Edit Admission Patient Details','Editar datos del paciente de Admisión',17
Insert into TempActionMaster Select'Edit BaseLine History','Editar Historial BaseLine',18
Insert into TempActionMaster Select'Edit Diagnosis','Editar Diagnóstico',19
Insert into TempActionMaster Select'Edit Investigation','Editar Investigación',20
Insert into TempActionMaster Select'Edit Patient Registration Details','Editar paciente su información de registro',21
Insert into TempActionMaster Select'Edit/Print Discharge Summary','Editar / Imprimir Resumen del alta',22
Insert into TempActionMaster Select'Final Settlement','Liquidación final',23
Insert into TempActionMaster Select'Generate Bill','generar Bill',24
Insert into TempActionMaster Select'Admission Notes','Notas de admisión',25
Insert into TempActionMaster Select'Make Bill Entry','Hacer de declaración de entrada',26
Insert into TempActionMaster Select'Make Due Chart Entry','Hacer Debido entrada de la carta',27
Insert into TempActionMaster Select'Make Investigation Entry','Hacer la entrada de Investigación',28
Insert into TempActionMaster Select'Make Visit Entry','Hacer consulta de ingreso',29
Insert into TempActionMaster Select'Operation Notes','Notas de la operación',30
Insert into TempActionMaster Select'Order Procedure','Procedimiento fin',31
Insert into TempActionMaster Select'Order Investigation','orden de Investigación',32
Insert into TempActionMaster Select'Perform Investigation','realizar Investigación',33
Insert into TempActionMaster Select'Print Bill','Bill Imprimir',34
Insert into TempActionMaster Select'Print CaseSheet','Imprimir CaseSheet',35
Insert into TempActionMaster Select'Print Consolidate Report','Imprimir Consolidar Informe',36
Insert into TempActionMaster Select'Print Discharge Summary','Imprimir Resumen del alta',37
Insert into TempActionMaster Select'Print Lab Report','Imprimir Informe de Laboratorio',38
Insert into TempActionMaster Select'Print Prescription','Imprimir Receta',39
Insert into TempActionMaster Select'Print OPD Prescription','Imprimir Receta OPD',40
Insert into TempActionMaster Select'Refund to Patient','La restitución del Paciente',41
Insert into TempActionMaster Select'Show Report','Mostrar reporte',42
Insert into TempActionMaster Select'Surgery Billing','facturación de la cirugía',43
Insert into TempActionMaster Select'Update Patient Details','Actualizar datos del paciente',44
Insert into TempActionMaster Select'Update StockInhand','actualización StockInhand',45
Insert into TempActionMaster Select'View & Cancel Bill','Ver y Cancelar Bill',46
Insert into TempActionMaster Select'View & Print Bill','Ver e imprimir Bill',47
Insert into TempActionMaster Select'View & Print Order','Ver y orden de impresión',48
Insert into TempActionMaster Select'View Bill','Ver factura',49
Insert into TempActionMaster Select'View Patient Case Detail','Vista detallada de casos de pacientes',50
Insert into TempActionMaster Select'View Visit Details','Ver detalles Visita',51
Insert into TempActionMaster Select'Add Drugs','Añadir Drogas',53
Insert into TempActionMaster Select'Print Label','Imprimir etiqueta',55
Insert into TempActionMaster Select'View Patient Details','Ver detalles del paciente',57
Insert into TempActionMaster Select'Print HealthPackage CaseSheet','Imprimir HealthPackage CaseSheet',58
Insert into TempActionMaster Select'Collect BMI','recoger el IMC',59
Insert into TempActionMaster Select'ViewPatientBMI','ViewPatientBMI',60
Insert into TempActionMaster Select'Upload Old Notes','Subir antiguas Notas',61
Insert into TempActionMaster Select'Add Referral / Certificate','Añadir Remisión / Certificado',62
Insert into TempActionMaster Select'Order services','Los servicios de giro',63
Insert into TempActionMaster Select'Print Patient Registration Details','Imprimir su información de registro de pacientes',64
Insert into TempActionMaster Select'Print Patient Admission Details','Imprimir detalles de Admisión de Pacientes',66
Insert into TempActionMaster Select'Approve Intend','La intención aprobar',67
Insert into TempActionMaster Select'View Intend','Ver Intend',68
Insert into TempActionMaster Select'Issue Intend','La intención tema',69
Insert into TempActionMaster Select'Labour And DeliveryNotes','Trabajo y DeliveryNotes',70
Insert into TempActionMaster Select'Discharge CheckList','CheckList de descarga',71
Insert into TempActionMaster Select'Print Discharge CheckList','CheckList de impresión de descarga',72
Insert into TempActionMaster Select'View/Edit Admission Notes','Ver / Editar notas de admisión',73
Insert into TempActionMaster Select'View/Edit Operation Notes','Ver / Editar Notas de la operación',74
Insert into TempActionMaster Select'Cancel Admission','Cancelar Admisión',75
Insert into TempActionMaster Select'Neonatal Notes','Notas neonatales',76
Insert into TempActionMaster Select'Print Neonatal Notes','Imprimir Notas neonatales',77
Insert into TempActionMaster Select'Print IPAdmissionData','imprimir IPAdmissionData',78
Insert into TempActionMaster Select'Refund Bill','Bill restitución',80
Insert into TempActionMaster Select'View Receipt','Ver recibo',81
Insert into TempActionMaster Select'Copy PO','copia PO',82
Insert into TempActionMaster Select'View Refund','Ver reembolso',83
Insert into TempActionMaster Select'Quick Bill','Bill rápida',84
Insert into TempActionMaster Select'Physiotherapy Notes','Notas de fisioterapia',85
Insert into TempActionMaster Select'View/Add diagnosis','Ver / Añadir diagnóstico',86
Insert into TempActionMaster Select'Cancel Order','Cancelar orden',87
Insert into TempActionMaster Select'Death Registration','registro de la muerte',88
Insert into TempActionMaster Select'View Bill','Ver factura',104
Insert into TempActionMaster Select'Issued Stock','Publicado Stock',105
Insert into TempActionMaster Select'Received Indent','recibido sangría',106
Insert into TempActionMaster Select'Approve Order','aprobar Orden',107
Insert into TempActionMaster Select'Approve Order','aprobar Orden',108
Insert into TempActionMaster Select'Approve Order','aprobar Orden',109
Insert into TempActionMaster Select'Dialysis Case Sheet','Hoja de diálisis Caso',110
Insert into TempActionMaster Select'Generate Bill','generar Bill',111
Insert into TempActionMaster Select'Make Bill Entry','Hacer de declaración de entrada',112
Insert into TempActionMaster Select'Make Visit Entry','Hacer consulta de ingreso',113
Insert into TempActionMaster Select'Make Visit Entry','Hacer consulta de ingreso',114
Insert into TempActionMaster Select'Print Bill','Bill Imprimir',115
Insert into TempActionMaster Select'Print Bill','Bill Imprimir',116
Insert into TempActionMaster Select'Print Prescription','Imprimir Receta',117
Insert into TempActionMaster Select'Refund to Patient','La restitución del Paciente',118
Insert into TempActionMaster Select'Show Report','Mostrar reporte',119
Insert into TempActionMaster Select'View & Print Order','Ver y orden de impresión',120
Insert into TempActionMaster Select'View & Print Order','Ver y orden de impresión',121
Insert into TempActionMaster Select'View & Print Order','Ver y orden de impresión',122
Insert into TempActionMaster Select'View & Print Order','Ver y orden de impresión',123
Insert into TempActionMaster Select'View Bill','Ver factura',124
Insert into TempActionMaster Select'View Bill','Ver factura',125
Insert into TempActionMaster Select'Issue Intend','La intención tema',126
Insert into TempActionMaster Select'Email Report','Informe e-mail',127
Insert into TempActionMaster Select'Collect Sample','recoger la Muestra',128
Insert into TempActionMaster Select'Reprint Barcode','Código de barras de Reproducción',129
Insert into TempActionMaster Select'Cancel Sample','Cancelar la Muestra',130
Insert into TempActionMaster Select'Aliquot','Alícuota',131
Insert into TempActionMaster Select'UploadPhoto','Subir foto',132
Insert into TempActionMaster Select'TRF_Upload','TRF_Upload',133
Insert into TempActionMaster Select'View Invoice','Mirar la factura',134
Insert into TempActionMaster Select'Receipts','Ingresos',135
Insert into TempActionMaster Select'Reject Sample','rechazar la Muestra',136
Insert into TempActionMaster Select'Approve Order','aprobar Orden',137
Insert into TempActionMaster Select'View & Cancel Kit','Ver y Cancelar Kit',138
Insert into TempActionMaster Select'Approve Order','aprobar Orden',139
Insert into TempActionMaster Select'View Kit','Ver Kit',140
Insert into TempActionMaster Select'Collect sample','recoger la muestra',141
Insert into TempActionMaster Select'Investigation Capture','Captura de investigación',142
Insert into TempActionMaster Select'Central Approve PO','Aprobar el centro PO',143
Insert into TempActionMaster Select'Capture OutSourcing Details','Capturar detalles de subcontratación',144
Insert into TempActionMaster Select'Send SMS','Enviar SMS',145
Insert into TempActionMaster Select'Dispatch Report','Informe de despacho',146
Insert into TempActionMaster Select'Cancel Bill','Cancelar Bill',147
Insert into TempActionMaster Select'Upload File','Subir archivo',148
Insert into TempActionMaster Select'Edit Patient Registration Details','Editar paciente su información de registro',149
Insert into TempActionMaster Select'Print Label','Imprimir etiqueta',150
Insert into TempActionMaster Select'Health Screening','Exámenes de salud',151
Insert into TempActionMaster Select'View Health Screening','Presentación de la vista de la salud',152
Insert into TempActionMaster Select'TransferSample','TransferSample',153
Insert into TempActionMaster Select'Reprint SRS','Reimpresión SRS',154
Insert into TempActionMaster Select'Show HealthCheckUp Report','Mostrar informe HealthCheckUp',155
Insert into TempActionMaster Select'Register Home Collection','Register Home Collection',156
Insert into TempActionMaster Select'Edit Patient HealthCheck Up','Editar HealthCheck paciente hasta',157
Insert into TempActionMaster Select'Edit Patient History','Editar Historia del Paciente',158
Insert into TempActionMaster Select'Edit Bill','Editar Bill',159
Insert into TempActionMaster Select'Show PDF','Mostrar PDF',160
Insert into TempActionMaster Select'Resend Report','Informe del reenvío',161
Insert into TempActionMaster Select'Send Outsource Details','Enviar externalizar detalles',162
Insert into TempActionMaster Select'Reprint TRF Barcode','Reimprimir TRF código de barras',163
Insert into TempActionMaster Select'Print','Impresión',164
Insert into TempActionMaster Select'Print','Impresión',165
Insert into TempActionMaster Select'Outsource Upload Document','Empresa de trabajo Cargar documento',166
Insert into TempActionMaster Select'Sample Rejection','El rechazo de la muestra',167
Insert into TempActionMaster Select'Sample Acceptance','La aceptación de la muestra',168
Insert into TempActionMaster Select'Collect Invoice','Suma de factura',169
Insert into TempActionMaster Select'Bulk Collect Sample','Recoger la muestra a granel',170
Insert into TempActionMaster Select'Slides','diapositivas',171
Insert into TempActionMaster Select'Cancel Order','Cancelar orden',173
Insert into TempActionMaster Select'Issued Stock','Publicado Stock',174
Insert into TempActionMaster Select'Received Indent','recibido sangría',175
Insert into TempActionMaster Select'View Intend','Ver Intend',176
Insert into TempActionMaster Select'Approve Order','aprobar Orden',177
Insert into TempActionMaster Select'View & Print Order','Ver y orden de impresión',178
Insert into TempActionMaster Select'Issue Intend','La intención tema',179
Insert into TempActionMaster Select'View Quotation','Ver Cotización',180
Insert into TempActionMaster Select'Approve Quotation','aprobar la cita',181
Insert into TempActionMaster Select'View & Print Order','Ver y orden de impresión',182


alter table ActionMaster
drop constraint PK__ActionMa__FFE3F4B90425A276


declare @language nvarchar(20) = 'es-ES'
insert into ActionMaster (ActionID,ActionName ,QueryString ,ActionCode ,IsShareable ,LanguageCode )
select distinct AM.ActionID,tbl.ChineseChar  ,AM.QueryString ,AM.ActionCode ,Am.IsShareable ,@language  from ActionMaster AM
inner join TempActionMaster tbl on tbl.Name =AM.ActionName  and AM.ActionID  =tbl.ActionID 
where AM.LanguageCode ='en-GB' 
-----------------------------------------------------------------------------------------------------------------------------------
----------------------For MenuMaster Table-----------------------------------------------------------------------------------------
drop table TempMenuMaster
Create table TempMenuMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000)) 

Insert into TempMenuMaster Select'Patient Search','Buscar paciente'
Insert into TempMenuMaster Select'Patient Registration','registro de Pacientes'
Insert into TempMenuMaster Select'Home','Casa'
Insert into TempMenuMaster Select'Reports','Informes'
Insert into TempMenuMaster Select'Set Reminders','establece recordatorios'
Insert into TempMenuMaster Select'Define Schedule','definir la Lista'
Insert into TempMenuMaster Select'Change Password','Cambia la contraseña'
Insert into TempMenuMaster Select'Investigation Report','Reporte de investigación'
Insert into TempMenuMaster Select'Cash Closure','Cierre de Caja'
Insert into TempMenuMaster Select'View Schedules','Ver Horarios'
Insert into TempMenuMaster Select'Today Visits','Visitas hoy'
Insert into TempMenuMaster Select'BillSearch','BillSearch'
Insert into TempMenuMaster Select'Patient Management','Gestión de Pacientes'
Insert into TempMenuMaster Select'View Room Details','Ver Detalles de la habitación'
Insert into TempMenuMaster Select'Visit Search','visita Buscar'
Insert into TempMenuMaster Select'Manage Rates','Manejo de tarifas'
Insert into TempMenuMaster Select'Add Investigation/Groups','Añadir Investigación / Grupos'
Insert into TempMenuMaster Select'Reference Range Mgmt','Referencia Rango de Mgmt'
Insert into TempMenuMaster Select'Manage User','Manejo de usuario'
Insert into TempMenuMaster Select'Cash Payments','Pagos en efectivo'
Insert into TempMenuMaster Select'Check Safety Code','Compruebe Código de Seguridad'
Insert into TempMenuMaster Select'Add Corporate & Client','Añadir Corporate & Client'
Insert into TempMenuMaster Select'Task ReAssign','tarea reasignar'
Insert into TempMenuMaster Select'Dashboard','Tablero'
Insert into TempMenuMaster Select'Settlement','Asentamiento'
Insert into TempMenuMaster Select'Billing','Facturación'
Insert into TempMenuMaster Select'Plan Vacation','plan de vacaciones'
Insert into TempMenuMaster Select'Purchase Order','Orden de compra'
Insert into TempMenuMaster Select'Stock Receive','Stock Recibir'
Insert into TempMenuMaster Select'Stock Return','archivo regreso'
Insert into TempMenuMaster Select'Stock Damage','El daño de la'
Insert into TempMenuMaster Select'Inventory Search','Buscar en el inventario'
Insert into TempMenuMaster Select'Categories','Categorías'
Insert into TempMenuMaster Select'Products','productos'
Insert into TempMenuMaster Select'Suppliers','proveedores'
Insert into TempMenuMaster Select'Stock Issued','acciones emitidas'
Insert into TempMenuMaster Select'Reorder level','Reordenar nivel'
Insert into TempMenuMaster Select'OP Billing','facturación OP'
Insert into TempMenuMaster Select'IP Billing','facturación IP'
Insert into TempMenuMaster Select'Bulkload','Carga masiva'
Insert into TempMenuMaster Select'Update Products','Actualizar los productos'
Insert into TempMenuMaster Select'Stock Report','Informe de la'
Insert into TempMenuMaster Select'Home','Casa'
Insert into TempMenuMaster Select'View Profile','Ver perfil'
Insert into TempMenuMaster Select'Change Password','Cambia la contraseña'
Insert into TempMenuMaster Select'In Bound Referral','En Remisión Bound'
Insert into TempMenuMaster Select'Out Bound Referral','Remisión a cabo Bound'
Insert into TempMenuMaster Select'Summary Reports','Los informes de resumen'
Insert into TempMenuMaster Select'Stock Details','Detalles de la'
Insert into TempMenuMaster Select'Stock Details','Detalles de la'
Insert into TempMenuMaster Select'All Schedules','todos los Horarios'
Insert into TempMenuMaster Select'Manage Test Kit','Administrar Test Kit'
Insert into TempMenuMaster Select'Manage Test Method','Administrar el método de prueba'
Insert into TempMenuMaster Select'Manage Test Principle','Administrar Principio de prueba'
Insert into TempMenuMaster Select'Manage Test Instrument','Manejo de instrumentos de prueba'
Insert into TempMenuMaster Select'ManagePackage','ManagePackage'
Insert into TempMenuMaster Select'ManageDischargeSequence No','Sin ManageDischargeSequence'
Insert into TempMenuMaster Select'Manage MedicalIndent','administrar MedicalIndent'
Insert into TempMenuMaster Select'TPASearch','TPASearch'
Insert into TempMenuMaster Select'Surgery Package','Cirugía del paquete'
Insert into TempMenuMaster Select'ReceiptSearch','ReceiptSearch'
Insert into TempMenuMaster Select'Manage RateCard','administrar ratecard'
Insert into TempMenuMaster Select'Help Video','Ayuda vídeo'
Insert into TempMenuMaster Select'Voucher Search','Vale de Búsqueda'
Insert into TempMenuMaster Select'Config Setting','config Marco'
Insert into TempMenuMaster Select'Communicable Diseases','Enfermedades contagiosas'
Insert into TempMenuMaster Select'ICD Code','Código ICD'
Insert into TempMenuMaster Select'Manage Rooms','Manejo de habitaciones'
Insert into TempMenuMaster Select'Bill Search','Bill Buscar'
Insert into TempMenuMaster Select'Add/Change Hospital','Añadir Hospital / Cambio'
Insert into TempMenuMaster Select'Add/Change Physician','Añadir / Cambiar Médico'
Insert into TempMenuMaster Select'Modality Schedule','Horario modalidad'
Insert into TempMenuMaster Select'Get Work Order','Recibe Orden de Trabajo'
Insert into TempMenuMaster Select'Get Work List','Obtener la lista de trabajo'
Insert into TempMenuMaster Select'Home','Casa'
Insert into TempMenuMaster Select'Home','Casa'
Insert into TempMenuMaster Select'Cash Closure','Cierre de Caja'
Insert into TempMenuMaster Select'Home','Casa'
Insert into TempMenuMaster Select'InvStatusChange','InvStatusChange'
Insert into TempMenuMaster Select'SequenceArrangement','SequenceArrangement'
Insert into TempMenuMaster Select'Manage Department','administrar Departamento'
Insert into TempMenuMaster Select'ReceiveSample','ReceiveSample'
Insert into TempMenuMaster Select'Drug Brand','Marca de drogas'
Insert into TempMenuMaster Select'NewInstanceCreation','NewInstanceCreation'
Insert into TempMenuMaster Select'Todays OP Visits','Visitas de hoy OP'
Insert into TempMenuMaster Select'Raise Intend','La intención Levante'
Insert into TempMenuMaster Select'Supplier Rate Mapping','Mapeo Tasa proveedor'
Insert into TempMenuMaster Select'Lab Quick Billing','Laboratorio de facturación rápida'
Insert into TempMenuMaster Select'Manage Barcode Patterns','Manejo de patrones de código de barras'
Insert into TempMenuMaster Select'Add Or Change Number Pattern','Añadir patrón o número de cambio'
Insert into TempMenuMaster Select'Sample Search','Ejemplo de búsqueda'
Insert into TempMenuMaster Select'Manage Investigation Computation','Manejo de Investigación Computación'
Insert into TempMenuMaster Select'Investigation Search','investigación Buscar'
Insert into TempMenuMaster Select'Home','Casa'
Insert into TempMenuMaster Select'Client Master','Maestro Client'
Insert into TempMenuMaster Select'Rate Mapping','Mapeo tasa'
Insert into TempMenuMaster Select'New Lab Quick Billing','Nuevo laboratorio de facturación rápida'
Insert into TempMenuMaster Select'Investigation Queue','investigación de cola'
Insert into TempMenuMaster Select'Patient Due Details','Paciente Debido detalles'
Insert into TempMenuMaster Select'Discount Master','Maestro de descuento'
Insert into TempMenuMaster Select'Manage Currency','Manejo de moneda'
Insert into TempMenuMaster Select'Policy Master','política Maestro'
Insert into TempMenuMaster Select'Report Template','Plantilla de informe'
Insert into TempMenuMaster Select'Trusted Org Access Mapping','Mapeo de confianza Org Acceso'
Insert into TempMenuMaster Select'Meta Master','Maestro meta'
Insert into TempMenuMaster Select'Client Payment Tracker','Cliente Pago Rastreador'
Insert into TempMenuMaster Select'Employee Master','Maestro empleado'
Insert into TempMenuMaster Select'Service Client Mapping','Mapeo de servicios del cliente'
Insert into TempMenuMaster Select'RoleMenuMapper','RoleMenuMapper'
Insert into TempMenuMaster Select'Investigation Product Mapping','Investigación Asignación de productos'
Insert into TempMenuMaster Select'Investigation StockUsageReport','investigación StockUsageReport'
Insert into TempMenuMaster Select'Inventory Location','inventario Localización'
Insert into TempMenuMaster Select'Central Purchase Order','Central de orden de compra'
Insert into TempMenuMaster Select'Central Stock Receive','Recibir el centro de la'
Insert into TempMenuMaster Select'Kit Definition','kit Definición'
Insert into TempMenuMaster Select'Kit Creation','Creación kit'
Insert into TempMenuMaster Select'Kit Search','kit de Búsqueda'
Insert into TempMenuMaster Select'IP Billing','facturación IP'
Insert into TempMenuMaster Select'Intend Search','tienen la intención Buscar'
Insert into TempMenuMaster Select'StockUsage','StockUsage'
Insert into TempMenuMaster Select'Investigation StockUsage Report','Informe de Investigación StockUsage'
Insert into TempMenuMaster Select'Equipment Maintenance Master','El mantenimiento del equipo maestro'
Insert into TempMenuMaster Select'Product Maintenance','mantenimiento producto'
Insert into TempMenuMaster Select'Product Maintenance Report','Producto Informe de Mantenimiento'
Insert into TempMenuMaster Select'Visit Episode Master','Visita del episodio Maestro'
Insert into TempMenuMaster Select'Inventory Mgmt','Gestión de inventario'
Insert into TempMenuMaster Select'Send SMS','Enviar SMS'
Insert into TempMenuMaster Select'ContainerMaster','ContainerMaster'
Insert into TempMenuMaster Select'Manage Location','Manejo de Localización'
Insert into TempMenuMaster Select'Client Billing','facturación de cliente'
Insert into TempMenuMaster Select'Analyzer Master','analizador de Maestro'
Insert into TempMenuMaster Select'Test Master','Maestro de prueba'
Insert into TempMenuMaster Select'Reason Master','Motivo Maestro'
Insert into TempMenuMaster Select'Service Quotation','Cotización servicio'
Insert into TempMenuMaster Select'Add New Investigation','Añadir nueva investigación'
Insert into TempMenuMaster Select'General Billing Master','Maestro de facturación general'
Insert into TempMenuMaster Select'Registration Billing','Registro de facturación'
Insert into TempMenuMaster Select'Cash Out Flow','Salida de caja'
Insert into TempMenuMaster Select'Manage Result Template','Administrar plantilla de resultados'
Insert into TempMenuMaster Select'Merge/unMerge','Fusionar / unmerge'
Insert into TempMenuMaster Select'BatchWise WorkList','discontinuo WorkList'
Insert into TempMenuMaster Select'Org Create User','Org Crear usuario'
Insert into TempMenuMaster Select'Sample Transfer','Transferencia de la muestra'
Insert into TempMenuMaster Select'Radiology Template','Plantilla de radiología'
Insert into TempMenuMaster Select'Home Collection','Home Collection'
Insert into TempMenuMaster Select'Investigation Quick Approval','Investigación rápida aprobación'
Insert into TempMenuMaster Select'View Report','Vista del informe'
Insert into TempMenuMaster Select'Device Mapping','La asignación de dispositivos'
Insert into TempMenuMaster Select'Bulk Registration','registro mayor'
Insert into TempMenuMaster Select'Collections','Colecciones'
Insert into TempMenuMaster Select'Batch wise Enterresult','Discontinua Enterresult'
Insert into TempMenuMaster Select'Manage Patient','Manejo del paciente'
Insert into TempMenuMaster Select'Credit Debit Summary','Resumen de débito del crédito'
Insert into TempMenuMaster Select'Analayser wise Enterresult','Analayser sabia Enterresult'
Insert into TempMenuMaster Select'Bulk Rate Changes','Mayor tasa de cambio'
Insert into TempMenuMaster Select'Report Dispatch','informe de Despacho'
Insert into TempMenuMaster Select'View Registration','Ver registro'
Insert into TempMenuMaster Select'Batch wise Result Validation','Discontinua resultado de la validación'
Insert into TempMenuMaster Select'Address Book','Directorio'
Insert into TempMenuMaster Select'BatchSheet','BatchSheet'
Insert into TempMenuMaster Select'ReceiveBatch','ReceiveBatch'
Insert into TempMenuMaster Select'New Report Dispatch','Nuevo informe de Despacho'
Insert into TempMenuMaster Select'Mass Unloading','La descarga de masas'
Insert into TempMenuMaster Select'Pending List','Lista de pendientes'
Insert into TempMenuMaster Select'Manage Interpretation Notes','Administrar Notas de Interpretación'
Insert into TempMenuMaster Select'Pattern Mapping','Mapeo patrón'
Insert into TempMenuMaster Select'Investigation Create/Update','Investigación Crear / Actualizar'
Insert into TempMenuMaster Select'Manage Referral Policy','Administrar Política de referencias'
Insert into TempMenuMaster Select'Client Management','Gestión de clientes'

Alter table MenuMaster
drop constraint PK_MenuMaster

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
insert into MenuMaster(MenuID,DisplayText,ParentId,OrgId,PageID,LanguageCode)
select distinct MM.MenuID,tbl.ChineseChar,MM.ParentId,OrgId,MM.PageID,@language from menumaster MM
inner join TempMenuMaster tbl on tbl.Name =  MM.DisplayText and OrgId = @OrgiD
where OrgId = @OrgiD 
------------------------------------------------------------------------------------------------------------------------------------
---------------------For MetaDataOrgMapping table-----------------------------------------------------------------------------------

drop table TempMetaDataOrgMapping
Create table TempMetaDataOrgMapping(Sno int, Name Varchar(1000),ChineseChar  Nvarchar(1000)) 

Insert into TempMetaDataOrgMapping Select 1,'1 Month','1 mes'
Insert into TempMetaDataOrgMapping Select 2,'15 Days','15 días'
Insert into TempMetaDataOrgMapping Select 3,'3 Column Group Contents','3 Contenido Grupo columnas'
Insert into TempMetaDataOrgMapping Select 4,'Abnormal','Anormal'
Insert into TempMetaDataOrgMapping Select 5,'ABO Group','Grupo ABO'
Insert into TempMetaDataOrgMapping Select 6,'Absent','Ausente'
Insert into TempMetaDataOrgMapping Select 7,'Acknowledgement/Receipt','Confirmación/recibo'
Insert into TempMetaDataOrgMapping Select 8,'Active','Activo'
Insert into TempMetaDataOrgMapping Select 9,'Add','Añadir'
Insert into TempMetaDataOrgMapping Select 10,'Add To Exist Batch','Agregar al lote existente'
Insert into TempMetaDataOrgMapping Select 11,'Advance','Anticipo'
Insert into TempMetaDataOrgMapping Select 12,'Advance Client Bill','Avanzar Factura cliente'
Insert into TempMetaDataOrgMapping Select 13,'Advance Collection','Avanzar Recopilación'
Insert into TempMetaDataOrgMapping Select 14,'Advance Refund','Avanzar reembolso'
Insert into TempMetaDataOrgMapping Select 15,'Advance Threshold','Avanzar Umbral'
Insert into TempMetaDataOrgMapping Select 16,'Advanced','Avanzado'
Insert into TempMetaDataOrgMapping Select 17,'Advertisement','Anuncio'
Insert into TempMetaDataOrgMapping Select 18,'Age','Edad'
Insert into TempMetaDataOrgMapping Select 19,'Agreement','Contrato'
Insert into TempMetaDataOrgMapping Select 20,'All','todo'
Insert into TempMetaDataOrgMapping Select 21,'ALogBase10','A base de registro 10'
Insert into TempMetaDataOrgMapping Select 22,'ALogBaseE','A base de registro E'
Insert into TempMetaDataOrgMapping Select 23,'AlphaNumeric','Alfa numéricos'
Insert into TempMetaDataOrgMapping Select 24,'am','am'
Insert into TempMetaDataOrgMapping Select 25,'Analytical Chemistry','Química analítica'
Insert into TempMetaDataOrgMapping Select 26,'Analyzer','analizador'
Insert into TempMetaDataOrgMapping Select 27,'Analyzer Based','Basado en analizador'
Insert into TempMetaDataOrgMapping Select 28,'Any','Alguna'
Insert into TempMetaDataOrgMapping Select 29,'Approved','Aprobado'
Insert into TempMetaDataOrgMapping Select 30,'April','Abril'
Insert into TempMetaDataOrgMapping Select 31,'August','Agosto'
Insert into TempMetaDataOrgMapping Select 32,'Auto Authorization Range','Rango de autorización automática'
Insert into TempMetaDataOrgMapping Select 33,'AutoApproval','Autoaprobar'
Insert into TempMetaDataOrgMapping Select 34,'AutoComplete','Autocompletar'
Insert into TempMetaDataOrgMapping Select 35,'AutoValidate','Autovalidar'
Insert into TempMetaDataOrgMapping Select 36,'B2B','Negocio a negocio'
Insert into TempMetaDataOrgMapping Select 37,'B2C','Negocio a consumidor'
Insert into TempMetaDataOrgMapping Select 38,'Barcode Number','Código de barras'
Insert into TempMetaDataOrgMapping Select 39,'Basic','básica'
Insert into TempMetaDataOrgMapping Select 40,'Batch','Lote'
Insert into TempMetaDataOrgMapping Select 41,'BCR-ABL – PCR','BCR-ABL – PCR'
Insert into TempMetaDataOrgMapping Select 42,'Bed','Cama'
Insert into TempMetaDataOrgMapping Select 43,'Beta-Thalassemia','Beta-talasemia'
Insert into TempMetaDataOrgMapping Select 44,'Between','Entre'
Insert into TempMetaDataOrgMapping Select 45,'Bi Directional','Bidireccional'
Insert into TempMetaDataOrgMapping Select 46,'Bill','Factura'
Insert into TempMetaDataOrgMapping Select 47,'BILL NO','Número de factura'
Insert into TempMetaDataOrgMapping Select 48,'Billed Amount','Total facturado'
Insert into TempMetaDataOrgMapping Select 49,'Billing','facturación'
Insert into TempMetaDataOrgMapping Select 50,'BK Polyoma Virus','Virus BK Polyoma'
Insert into TempMetaDataOrgMapping Select 51,'Booked','reservado'
Insert into TempMetaDataOrgMapping Select 52,'Booking Number','Número de reservación'
Insert into TempMetaDataOrgMapping Select 53,'Both','ambos'
Insert into TempMetaDataOrgMapping Select 54,'Both(SMS And E-Mail)','ambos (SMS y correo electrónico)'
Insert into TempMetaDataOrgMapping Select 55,'Building','Edificio'
Insert into TempMetaDataOrgMapping Select 56,'Cancelled','anulado'
Insert into TempMetaDataOrgMapping Select 57,'CANDIDA-PCR','CANDIDA-PCR'
Insert into TempMetaDataOrgMapping Select 58,'Card Damaged','tarjeta dañada'
Insert into TempMetaDataOrgMapping Select 59,'Card Lost','Tarjeta perdida'
Insert into TempMetaDataOrgMapping Select 60,'Cash','en efectivo'
Insert into TempMetaDataOrgMapping Select 61,'Cash In Flow','flujo de efectivo'
Insert into TempMetaDataOrgMapping Select 62,'Cash with Advance','Efectivo con avance'
Insert into TempMetaDataOrgMapping Select 63,'Cash with Copay','Efectivo con copago'
Insert into TempMetaDataOrgMapping Select 64,'Cephalosporins','cefalosporinas'
Insert into TempMetaDataOrgMapping Select 65,'Cheque','Cheque'
Insert into TempMetaDataOrgMapping Select 66,'Chlamydia-PCR','Clamidia-PCR'
Insert into TempMetaDataOrgMapping Select 67,'City','ciudad'
Insert into TempMetaDataOrgMapping Select 68,'CLIENT','cliente'
Insert into TempMetaDataOrgMapping Select 69,'Client Access','acceso al cliente'
Insert into TempMetaDataOrgMapping Select 70,'Clinic','Clínica'
Insert into TempMetaDataOrgMapping Select 71,'CLINICAL RESEARCH COORDINATOR','COORDINADOR DE INVESTIGACION CLINICA'
Insert into TempMetaDataOrgMapping Select 72,'cm','CM'
Insert into TempMetaDataOrgMapping Select 73,'CMV Quantitative','CMV Cuantitativa'
Insert into TempMetaDataOrgMapping Select 74,'CMV-Detection-PCR','CMV-Detección-PCR'
Insert into TempMetaDataOrgMapping Select 75,'Co Payment','Co pago'
Insert into TempMetaDataOrgMapping Select 76,'Collect Advance','Recoger avance'
Insert into TempMetaDataOrgMapping Select 77,'Collect Deposit','Recaudar depósito'
Insert into TempMetaDataOrgMapping Select 78,'Collect sample','recoja la muestra'
Insert into TempMetaDataOrgMapping Select 79,'Collect Surgery Advance','Recoger avance cirugía'
Insert into TempMetaDataOrgMapping Select 80,'CollectionCenters/OrgLocations','Recopilación de centros/localización de organizaciones'
Insert into TempMetaDataOrgMapping Select 81,'Common','común'
Insert into TempMetaDataOrgMapping Select 82,'Completed','completo'
Insert into TempMetaDataOrgMapping Select 83,'Consultation','Consulta'
Insert into TempMetaDataOrgMapping Select 84,'Credit','Crédito'
Insert into TempMetaDataOrgMapping Select 85,'Credit Note','Nota de crédito'
Insert into TempMetaDataOrgMapping Select 86,'Credit with Copay','Crédito con avance'
Insert into TempMetaDataOrgMapping Select 87,'Credit&Cash','Crédito y Efectivo'
Insert into TempMetaDataOrgMapping Select 88,'CreditDebitSummary','Resumen crédito débito'
Insert into TempMetaDataOrgMapping Select 89,'Critical Range','Rango crítico'
Insert into TempMetaDataOrgMapping Select 90,'Cryptococcus-PCR','Cryptococcus-PCR'
Insert into TempMetaDataOrgMapping Select 91,'CT','Tomografía computarizada'
Insert into TempMetaDataOrgMapping Select 92,'CustomPeriod','Periodo a la medida'
Insert into TempMetaDataOrgMapping Select 93,'Daily','Diariamente'
Insert into TempMetaDataOrgMapping Select 94,'DateTime','Fecha Hora'
Insert into TempMetaDataOrgMapping Select 95,'day of the month','día del mes'
Insert into TempMetaDataOrgMapping Select 96,'day of the week','día de la semana'
Insert into TempMetaDataOrgMapping Select 97,'Day(s)','Día(s)'
Insert into TempMetaDataOrgMapping Select 98,'Days','Días'
Insert into TempMetaDataOrgMapping Select 99,'December','diciembre'
Insert into TempMetaDataOrgMapping Select 100,'Decreased','Reducido'
Insert into TempMetaDataOrgMapping Select 101,'Dengue-PCR','Dengue-PCR'
Insert into TempMetaDataOrgMapping Select 102,'Department','Departamento'
Insert into TempMetaDataOrgMapping Select 103,'Department Based','Basado en departamento'
Insert into TempMetaDataOrgMapping Select 104,'Deposit','depósito'
Insert into TempMetaDataOrgMapping Select 105,'Detail','Detalle'
Insert into TempMetaDataOrgMapping Select 106,'Detailed','Detallado'
Insert into TempMetaDataOrgMapping Select 107,'Digoxin','digoxina'
Insert into TempMetaDataOrgMapping Select 108,'Discount','Descuento'
Insert into TempMetaDataOrgMapping Select 109,'Discount Policy','política del descuento'
Insert into TempMetaDataOrgMapping Select 110,'Dispatch Checklist','envíe lista de verificación'
Insert into TempMetaDataOrgMapping Select 111,'Divorced','Divorciado'
Insert into TempMetaDataOrgMapping Select 112,'Doctor/Clinic Delivery','Suministro médico/clínico'
Insert into TempMetaDataOrgMapping Select 113,'Domain Range','Rango de dominio'
Insert into TempMetaDataOrgMapping Select 114,'Draft','Borrador'
Insert into TempMetaDataOrgMapping Select 115,'Due Receipt','recibo de adeudo'
Insert into TempMetaDataOrgMapping Select 116,'Early Morning','Por la mañana temprano'
Insert into TempMetaDataOrgMapping Select 117,'EBV-PCR','VEB-PCR'
Insert into TempMetaDataOrgMapping Select 118,'Email','correo electrónico'
Insert into TempMetaDataOrgMapping Select 119,'E-Mail','correo electrónico'
Insert into TempMetaDataOrgMapping Select 120,'Emergency','Emergencia'
Insert into TempMetaDataOrgMapping Select 121,'End of Study','Fin del estudio'
Insert into TempMetaDataOrgMapping Select 122,'EveryMonth','Cada mes'
Insert into TempMetaDataOrgMapping Select 123,'Factor V','Factor V'
Insert into TempMetaDataOrgMapping Select 124,'Fasting','Rápido'
Insert into TempMetaDataOrgMapping Select 125,'Fax','FAX'
Insert into TempMetaDataOrgMapping Select 126,'February','febrero'
Insert into TempMetaDataOrgMapping Select 127,'Female','femenino'
Insert into TempMetaDataOrgMapping Select 128,'Fitness','Buena forma'
Insert into TempMetaDataOrgMapping Select 129,'Floor','Piso'
Insert into TempMetaDataOrgMapping Select 130,'FlowCyto','Citometría de flujo'
Insert into TempMetaDataOrgMapping Select 131,'Formula','Fórmula'
Insert into TempMetaDataOrgMapping Select 132,'Fri','Viernes'
Insert into TempMetaDataOrgMapping Select 133,'Frozen Section','Sección congelada'
Insert into TempMetaDataOrgMapping Select 134,'Fully Day','Día completo'
Insert into TempMetaDataOrgMapping Select 135,'Fully Recovered','Totalmente recuperado'
Insert into TempMetaDataOrgMapping Select 136,'Gender','Género'
Insert into TempMetaDataOrgMapping Select 137,'General Billing Items','Elementos de facturación general'
Insert into TempMetaDataOrgMapping Select 138,'General Health Checkup','Chequeo de salud general'
Insert into TempMetaDataOrgMapping Select 139,'Generate New Batch','Generar nuevo lote'
Insert into TempMetaDataOrgMapping Select 140,'grade I','Grado I'
Insert into TempMetaDataOrgMapping Select 141,'grade0','Grado 0'
Insert into TempMetaDataOrgMapping Select 142,'Group','Grupo'
Insert into TempMetaDataOrgMapping Select 143,'Group Content','Contenido del grupo'
Insert into TempMetaDataOrgMapping Select 144,'Group Contents in Column','Contenido del grupo en la Columna'
Insert into TempMetaDataOrgMapping Select 145,'Hair Loss','Pérdida del cabello'
Insert into TempMetaDataOrgMapping Select 146,'Half Day','de medio día'
Insert into TempMetaDataOrgMapping Select 147,'HBV-Drug Genotyping','Hepatitis B- Genotipo de fármacos'
Insert into TempMetaDataOrgMapping Select 148,'HBV-Drug Resistance','Hepatitis B- Resistencia a fármacos'
Insert into TempMetaDataOrgMapping Select 149,'HBV-Qualitative','Hepatitis B- Cualitativa'
Insert into TempMetaDataOrgMapping Select 150,'HBV-Quantitative','Hepatitis B-Cuantitativa'
Insert into TempMetaDataOrgMapping Select 151,'Health Packages','Paquetes de salud'
Insert into TempMetaDataOrgMapping Select 152,'Heavy','Pesado'
Insert into TempMetaDataOrgMapping Select 153,'Hematoxylin and Eosin','Hematoxilina y eosina'
Insert into TempMetaDataOrgMapping Select 154,'HoldBoth','Mantener ambos'
Insert into TempMetaDataOrgMapping Select 155,'HoldRegistration','Mantener registro'
Insert into TempMetaDataOrgMapping Select 156,'HoldReport','Mantener informe'
Insert into TempMetaDataOrgMapping Select 157,'HomeDelivery','Servicio a domicilio'
Insert into TempMetaDataOrgMapping Select 158,'Hospital','Hospital'
Insert into TempMetaDataOrgMapping Select 159,'Hour Basic','hora básica'
Insert into TempMetaDataOrgMapping Select 160,'Hour(s)','hora(s)'
Insert into TempMetaDataOrgMapping Select 161,'IMAGING','IMÁGENES'
Insert into TempMetaDataOrgMapping Select 162,'InActive','Inactivo'
Insert into TempMetaDataOrgMapping Select 163,'Inbound','Entrante'
Insert into TempMetaDataOrgMapping Select 164,'Increased','Aumentado'
Insert into TempMetaDataOrgMapping Select 165,'Insurance','Seguro'
Insert into TempMetaDataOrgMapping Select 166,'InterNational','Internacional'
Insert into TempMetaDataOrgMapping Select 167,'Interpretation','Interpretación'
Insert into TempMetaDataOrgMapping Select 168,'Interpretation and Value','Interpretación y Valor'
Insert into TempMetaDataOrgMapping Select 169,'Investigation','Investigación'
Insert into TempMetaDataOrgMapping Select 170,'Investigation Fee','Honorarios investigación'
Insert into TempMetaDataOrgMapping Select 171,'Investigation Group Fee','Honorarios grupo de investigación'
Insert into TempMetaDataOrgMapping Select 172,'Investigation Groups','Grupos de investigación'
Insert into TempMetaDataOrgMapping Select 173,'Investigation Report','Reporte de investigación'
Insert into TempMetaDataOrgMapping Select 174,'InvestigationMaster','Maestro Investigación'
Insert into TempMetaDataOrgMapping Select 175,'Investigations','investigaciones'
Insert into TempMetaDataOrgMapping Select 176,'Invoice','FACTURA'
Insert into TempMetaDataOrgMapping Select 177,'INVOICE NO','Número de factura'
Insert into TempMetaDataOrgMapping Select 178,'Invoice To Client','Factura para cliente'
Insert into TempMetaDataOrgMapping Select 179,'IP','Paciente enterno'
Insert into TempMetaDataOrgMapping Select 180,'IP Payments','Pagos Paciente enterno'
Insert into TempMetaDataOrgMapping Select 181,'IsDefaultBilling','Factura predeterminada'
Insert into TempMetaDataOrgMapping Select 182,'IsDiscountable','Descontable'
Insert into TempMetaDataOrgMapping Select 183,'IsTaxable','Está sujeto a impuestos'
Insert into TempMetaDataOrgMapping Select 184,'IsVariable','Variable'
Insert into TempMetaDataOrgMapping Select 185,'January','Enero'
Insert into TempMetaDataOrgMapping Select 186,'July','julio'
Insert into TempMetaDataOrgMapping Select 187,'June','junio'
Insert into TempMetaDataOrgMapping Select 188,'Lab','LABORATORIO'
Insert into TempMetaDataOrgMapping Select 189,'Lab Investigation','Investigación laboratorio'
Insert into TempMetaDataOrgMapping Select 190,'Lab Items','Elementos de laboratorio'
Insert into TempMetaDataOrgMapping Select 191,'LandLine','teléfono fijo'
Insert into TempMetaDataOrgMapping Select 192,'Last Month','El mes pasado'
Insert into TempMetaDataOrgMapping Select 193,'Last Week','La semana pasada'
Insert into TempMetaDataOrgMapping Select 194,'Last Year','El año pasado'
Insert into TempMetaDataOrgMapping Select 195,'Left','Izquierda'
Insert into TempMetaDataOrgMapping Select 196,'Lesser of Billed And Pre-Auth','Menor de facturada o pre-autorizada'
Insert into TempMetaDataOrgMapping Select 197,'Letter','Carta'
Insert into TempMetaDataOrgMapping Select 198,'logBase10','Base de registro 10'
Insert into TempMetaDataOrgMapping Select 199,'logBaseE','Base de registro E'
Insert into TempMetaDataOrgMapping Select 200,'Magazine','Revista'
Insert into TempMetaDataOrgMapping Select 201,'Make Bill','Hacer factura'
Insert into TempMetaDataOrgMapping Select 202,'Male','Masculino'
Insert into TempMetaDataOrgMapping Select 203,'Mapped Services','Servicios de asignación'
Insert into TempMetaDataOrgMapping Select 204,'March','marzo'
Insert into TempMetaDataOrgMapping Select 205,'Married','Casado'
Insert into TempMetaDataOrgMapping Select 206,'May','Mayo'
Insert into TempMetaDataOrgMapping Select 207,'Medical','Hospital'
Insert into TempMetaDataOrgMapping Select 208,'Medical Indents Rates','Tasa de pedidos médicos'
Insert into TempMetaDataOrgMapping Select 209,'mg','Mg'
Insert into TempMetaDataOrgMapping Select 210,'Micro Serology','Serología Micro'
Insert into TempMetaDataOrgMapping Select 211,'Microwave Value','Valor microondas'
Insert into TempMetaDataOrgMapping Select 212,'Minute(s)','minuto(s)'
Insert into TempMetaDataOrgMapping Select 213,'ml','ml'
Insert into TempMetaDataOrgMapping Select 214,'mm','mm'
Insert into TempMetaDataOrgMapping Select 215,'MMM','MMM'
Insert into TempMetaDataOrgMapping Select 216,'Mobile','Móvil'
Insert into TempMetaDataOrgMapping Select 217,'Mobile/Phone','Teléfono/ móvil'
Insert into TempMetaDataOrgMapping Select 218,'Moderate','Moderar'
Insert into TempMetaDataOrgMapping Select 219,'Mon','Lunes'
Insert into TempMetaDataOrgMapping Select 220,'Monitoring','Control'
Insert into TempMetaDataOrgMapping Select 221,'Month(s)','Mese(s)'
Insert into TempMetaDataOrgMapping Select 222,'Monthly','Mensual'
Insert into TempMetaDataOrgMapping Select 223,'Months','Meses'
Insert into TempMetaDataOrgMapping Select 224,'MOU','memorando de entendimiento'
Insert into TempMetaDataOrgMapping Select 225,'MRI','Imagen por resonancia magnética (IRM)'
Insert into TempMetaDataOrgMapping Select 226,'Name','Nombre'
Insert into TempMetaDataOrgMapping Select 227,'National','Nacional'
Insert into TempMetaDataOrgMapping Select 228,'Next 1 Day','Siguiente 1 Día'
Insert into TempMetaDataOrgMapping Select 229,'Next 1 Week','Siguiente 1 Semana'
Insert into TempMetaDataOrgMapping Select 230,'Non Printed','no impreso'
Insert into TempMetaDataOrgMapping Select 231,'None','Ninguna'
Insert into TempMetaDataOrgMapping Select 232,'Normal','Normal'
Insert into TempMetaDataOrgMapping Select 233,'Not Recovered','No recuperado'
Insert into TempMetaDataOrgMapping Select 234,'NotKnown','No conocido'
Insert into TempMetaDataOrgMapping Select 235,'November','noviembre'
Insert into TempMetaDataOrgMapping Select 236,'Number','Número'
Insert into TempMetaDataOrgMapping Select 237,'Numeric','Numérico'
Insert into TempMetaDataOrgMapping Select 238,'Occupation','ocupacion'
Insert into TempMetaDataOrgMapping Select 239,'October','octubre'
Insert into TempMetaDataOrgMapping Select 240,'On-call','de guardia'
Insert into TempMetaDataOrgMapping Select 241,'OP','Paciente externo'
Insert into TempMetaDataOrgMapping Select 242,'OP&IP','Paciente externo y paciente interno'
Insert into TempMetaDataOrgMapping Select 243,'Order Investigation','orden de Investigación'
Insert into TempMetaDataOrgMapping Select 244,'Ordered Location','Localización solicitada'
Insert into TempMetaDataOrgMapping Select 245,'Orginal','Original'
Insert into TempMetaDataOrgMapping Select 246,'Other','Otro'
Insert into TempMetaDataOrgMapping Select 247,'OTHERS','OTROS'
Insert into TempMetaDataOrgMapping Select 248,'Outsource','Externalizar'
Insert into TempMetaDataOrgMapping Select 249,'Outsource Doc','documento de subcontratación'
Insert into TempMetaDataOrgMapping Select 250,'Package','Paquete'
Insert into TempMetaDataOrgMapping Select 251,'Package Content','Contenido del paquete'
Insert into TempMetaDataOrgMapping Select 252,'PAP Smear','Citología  vaginal'
Insert into TempMetaDataOrgMapping Select 253,'Partially Recovered','Parcialmente recuperado'
Insert into TempMetaDataOrgMapping Select 254,'Patient','Paciente'
Insert into TempMetaDataOrgMapping Select 255,'Pencillin','penicilina'
Insert into TempMetaDataOrgMapping Select 256,'Pending','Pendiente'
Insert into TempMetaDataOrgMapping Select 257,'Percentage','Porcentaje'
Insert into TempMetaDataOrgMapping Select 258,'Phase 1','Fase 1'
Insert into TempMetaDataOrgMapping Select 259,'Physician','Médico'
Insert into TempMetaDataOrgMapping Select 260,'Physician Fee','Honorarios médicos'
Insert into TempMetaDataOrgMapping Select 261,'PID','Enfermedad inflamatoria pélvica'
Insert into TempMetaDataOrgMapping Select 262,'pm','PM'
Insert into TempMetaDataOrgMapping Select 263,'Portrait Format','formato portable'
Insert into TempMetaDataOrgMapping Select 264,'Post-Prandial','Post-Prandial'
Insert into TempMetaDataOrgMapping Select 265,'Power','Poder'
Insert into TempMetaDataOrgMapping Select 266,'Pre-Auth Amount','Pre Autorización del monto'
Insert into TempMetaDataOrgMapping Select 267,'Premium','Recargo'
Insert into TempMetaDataOrgMapping Select 268,'Present','Presente'
Insert into TempMetaDataOrgMapping Select 269,'Price Sheet','Hoja de precios'
Insert into TempMetaDataOrgMapping Select 270,'PRINCIPAL INVESTIGATOR','INVESTIGADOR PRINCIPAL'
Insert into TempMetaDataOrgMapping Select 271,'Printable Range','Rango para imprimir'
Insert into TempMetaDataOrgMapping Select 272,'Printed','Impreso'
Insert into TempMetaDataOrgMapping Select 273,'Procedure Fee','Costes del proceso'
Insert into TempMetaDataOrgMapping Select 274,'Process Location','Proceso de Localización'
Insert into TempMetaDataOrgMapping Select 275,'PROJECT MANAGER','GESTOR DE PROYECTO'
Insert into TempMetaDataOrgMapping Select 276,'Proportional','Proporcional'
Insert into TempMetaDataOrgMapping Select 277,'ProtocalGroup','Grupo Protocal'
Insert into TempMetaDataOrgMapping Select 278,'Random','Aleatorio'
Insert into TempMetaDataOrgMapping Select 279,'Randomization','Aleatoriedad'
Insert into TempMetaDataOrgMapping Select 280,'Rate Policy','Tasa de interés'
Insert into TempMetaDataOrgMapping Select 281,'RateMaster','Maestro Tasa'
Insert into TempMetaDataOrgMapping Select 282,'Receipt','Recibo'
Insert into TempMetaDataOrgMapping Select 283,'Receipt Dispatch','Envio de recibo'
Insert into TempMetaDataOrgMapping Select 284,'Receivables','Pendientes'
Insert into TempMetaDataOrgMapping Select 285,'Received','Recibido'
Insert into TempMetaDataOrgMapping Select 286,'Recheck','Revisar'
Insert into TempMetaDataOrgMapping Select 287,'Recollect','recolección'
Insert into TempMetaDataOrgMapping Select 288,'Reduce','reducir'
Insert into TempMetaDataOrgMapping Select 289,'Reference','Referencia'
Insert into TempMetaDataOrgMapping Select 290,'Reference Range','Rango de referencia'
Insert into TempMetaDataOrgMapping Select 291,'ReferingPhysician','Médico de referencia'
Insert into TempMetaDataOrgMapping Select 292,'Referral','Referencia'
Insert into TempMetaDataOrgMapping Select 293,'Referred','Referido'
Insert into TempMetaDataOrgMapping Select 294,'Referring Physician','Médico de referencia'
Insert into TempMetaDataOrgMapping Select 295,'Reflex','Reflejo'
Insert into TempMetaDataOrgMapping Select 296,'Reflexwithnewsample','Reflejar en nueva muestra'
Insert into TempMetaDataOrgMapping Select 297,'Registered','Registrado'
Insert into TempMetaDataOrgMapping Select 298,'Registration','Registro'
Insert into TempMetaDataOrgMapping Select 299,'Regular Consultant','Especialista habitual'
Insert into TempMetaDataOrgMapping Select 300,'Remote Registration','Registro aislado'
Insert into TempMetaDataOrgMapping Select 301,'Report','Reporte'
Insert into TempMetaDataOrgMapping Select 302,'Report Checklis','Informe de listas de control'
Insert into TempMetaDataOrgMapping Select 303,'Report Dispatch','Reporte de Despacho'
Insert into TempMetaDataOrgMapping Select 304,'Residential Medical Officer','Funcionario médico residente'
Insert into TempMetaDataOrgMapping Select 305,'Results Interpretation Range','Rango de interpretación de resultados'
Insert into TempMetaDataOrgMapping Select 306,'ResultSummary','Resumen Resultados'
Insert into TempMetaDataOrgMapping Select 307,'Retest','reprobar'
Insert into TempMetaDataOrgMapping Select 308,'Revenue','Impuestos'
Insert into TempMetaDataOrgMapping Select 309,'Right','derecho'
Insert into TempMetaDataOrgMapping Select 310,'Rooms','Habitaciones'
Insert into TempMetaDataOrgMapping Select 311,'RoomType','Tipo de habitación'
Insert into TempMetaDataOrgMapping Select 312,'Round','redondo'
Insert into TempMetaDataOrgMapping Select 313,'Routine','Rutina'
Insert into TempMetaDataOrgMapping Select 314,'Sample','Muestra'
Insert into TempMetaDataOrgMapping Select 315,'Sample Based','Basado en muestra'
Insert into TempMetaDataOrgMapping Select 316,'Sample Collected','Muestra recogida'
Insert into TempMetaDataOrgMapping Select 317,'Sample ID','identificación de la muestra'
Insert into TempMetaDataOrgMapping Select 318,'Sample Loaded','muestra cargada'
Insert into TempMetaDataOrgMapping Select 319,'Sample Received','Muestra recibida'
Insert into TempMetaDataOrgMapping Select 320,'Sample Storage Units','Unidades de almacenamiento muestra'
Insert into TempMetaDataOrgMapping Select 321,'Sat','Sab'
Insert into TempMetaDataOrgMapping Select 322,'Scan','Escáner'
Insert into TempMetaDataOrgMapping Select 323,'Scanty','Escaso'
Insert into TempMetaDataOrgMapping Select 324,'Screening','Filtración'
Insert into TempMetaDataOrgMapping Select 325,'Second(s)','segundo(s)'
Insert into TempMetaDataOrgMapping Select 326,'Select','Seleccionar'
Insert into TempMetaDataOrgMapping Select 327,'--Select--','--Seleccionar--'
Insert into TempMetaDataOrgMapping Select 328,'---Select---','---Seleccionar---'
Insert into TempMetaDataOrgMapping Select 329,'Select a reason','Seleccione una razón'
Insert into TempMetaDataOrgMapping Select 330,'September','Septiembre'
Insert into TempMetaDataOrgMapping Select 331,'ServiceCode','Código del servicio'
Insert into TempMetaDataOrgMapping Select 332,'Shellfish','Mariscos'
Insert into TempMetaDataOrgMapping Select 333,'Single','Soltero'
Insert into TempMetaDataOrgMapping Select 334,'SLA','acuerdo de nivel de servicio'
Insert into TempMetaDataOrgMapping Select 335,'Slot','Puesto'
Insert into TempMetaDataOrgMapping Select 336,'SMS','Mensaje'
Insert into TempMetaDataOrgMapping Select 337,'SOP','Procedimiento operativo estándar'
Insert into TempMetaDataOrgMapping Select 338,'Source','Origen'
Insert into TempMetaDataOrgMapping Select 339,'Special','Especial'
Insert into TempMetaDataOrgMapping Select 340,'Special Chemistry','Química Especial'
Insert into TempMetaDataOrgMapping Select 341,'Staff','Personal'
Insert into TempMetaDataOrgMapping Select 342,'Staff-Dependent','Personal-dependiente'
Insert into TempMetaDataOrgMapping Select 343,'Stat','Estadística'
Insert into TempMetaDataOrgMapping Select 344,'Storage Area','Zona de almacenamiento'
Insert into TempMetaDataOrgMapping Select 345,'Suggestions','Sugerencias'
Insert into TempMetaDataOrgMapping Select 346,'SulphaDrugs','Sulfamidas'
Insert into TempMetaDataOrgMapping Select 347,'Summary','Resumen'
Insert into TempMetaDataOrgMapping Select 348,'Sun','El sol'
Insert into TempMetaDataOrgMapping Select 349,'Surgery Bill','Factura cirugía'
Insert into TempMetaDataOrgMapping Select 350,'SurgeryPackage','Paquete de Cirugía'
Insert into TempMetaDataOrgMapping Select 351,'Suspend','Suspender'
Insert into TempMetaDataOrgMapping Select 352,'TB-PCR','PCR para TB'
Insert into TempMetaDataOrgMapping Select 353,'TB-TMA','TMA para TB'
Insert into TempMetaDataOrgMapping Select 354,'Technical','Técnico'
Insert into TempMetaDataOrgMapping Select 355,'Television','Televisión'
Insert into TempMetaDataOrgMapping Select 356,'Tender','Moneda'
Insert into TempMetaDataOrgMapping Select 357,'Terminate','terminar'
Insert into TempMetaDataOrgMapping Select 358,'Test Based','Basado en Prueba'
Insert into TempMetaDataOrgMapping Select 359,'TextReport','Informe Texto'
Insert into TempMetaDataOrgMapping Select 360,'This Month','este mes'
Insert into TempMetaDataOrgMapping Select 361,'This Week','esta semana'
Insert into TempMetaDataOrgMapping Select 362,'This Year','Este año'
Insert into TempMetaDataOrgMapping Select 363,'Threshold amount in value','Cantidad límite en valor'
Insert into TempMetaDataOrgMapping Select 364,'Thu','Jueves'
Insert into TempMetaDataOrgMapping Select 365,'Today','Hoy'
Insert into TempMetaDataOrgMapping Select 366,'TODInvoice','Factura TOD'
Insert into TempMetaDataOrgMapping Select 367,'toFixed','para fijar'
Insert into TempMetaDataOrgMapping Select 368,'Tomato','Tomate'
Insert into TempMetaDataOrgMapping Select 369,'Transferred','transferido'
Insert into TempMetaDataOrgMapping Select 370,'Tray','La bandeja'
Insert into TempMetaDataOrgMapping Select 371,'Treatment Procedure','Procedimiento de tratamiento'
Insert into TempMetaDataOrgMapping Select 372,'TRF Upload','Subir formulario informe de prueba'
Insert into TempMetaDataOrgMapping Select 373,'Tue','Mar'
Insert into TempMetaDataOrgMapping Select 374,'Unconscious','Inconsciente'
Insert into TempMetaDataOrgMapping Select 375,'Uni Directional','Unidireccional'
Insert into TempMetaDataOrgMapping Select 376,'Un-Mapped Service','servicio desasignado'
Insert into TempMetaDataOrgMapping Select 377,'Unstable','Inestable'
Insert into TempMetaDataOrgMapping Select 378,'Urinalysis','Análisis de orina'
Insert into TempMetaDataOrgMapping Select 379,'Urine Drug','Drogas en orina'
Insert into TempMetaDataOrgMapping Select 380,'Urine Pregnancy Test','Prueba de embarazo en orina'
Insert into TempMetaDataOrgMapping Select 381,'UserMaster','Maestro usuario'
Insert into TempMetaDataOrgMapping Select 382,'Value','Valor'
Insert into TempMetaDataOrgMapping Select 383,'Variable','Variable'
Insert into TempMetaDataOrgMapping Select 384,'VDRL (RPR)','VDRL (RPR)'
Insert into TempMetaDataOrgMapping Select 385,'Vendor','Vendedor'
Insert into TempMetaDataOrgMapping Select 386,'View Exist Batch','Ver los lotes existe'
Insert into TempMetaDataOrgMapping Select 387,'VIP','Persona muy importante'
Insert into TempMetaDataOrgMapping Select 388,'Virtual Credit %','Crédito virtual %'
Insert into TempMetaDataOrgMapping Select 389,'Virtual Credit Amt','Monto de crédito virtual'
Insert into TempMetaDataOrgMapping Select 390,'Visit No.','Nro. de Visita'
Insert into TempMetaDataOrgMapping Select 391,'Visit Number','número  de Visita'
Insert into TempMetaDataOrgMapping Select 392,'Visiting consultant','Especialista de visita'
Insert into TempMetaDataOrgMapping Select 393,'VODInvoice','Factura VOD'
Insert into TempMetaDataOrgMapping Select 394,'Volume','Volumen'
Insert into TempMetaDataOrgMapping Select 395,'Ward','Sala'
Insert into TempMetaDataOrgMapping Select 396,'Wed','Mie'
Insert into TempMetaDataOrgMapping Select 397,'Week(s)','Semana(s)'
Insert into TempMetaDataOrgMapping Select 398,'Weekly','Semanal'
Insert into TempMetaDataOrgMapping Select 399,'Weeks','Semanas'
Insert into TempMetaDataOrgMapping Select 400,'Widow','Viuda'
Insert into TempMetaDataOrgMapping Select 401,'WorkListID Based','Basado en identificador de lista de trabajo'
Insert into TempMetaDataOrgMapping Select 402,'X-Ray','Rayos X'
Insert into TempMetaDataOrgMapping Select 403,'Year','Año'
Insert into TempMetaDataOrgMapping Select 404,'Year(s)','Año(s)'
Insert into TempMetaDataOrgMapping Select 405,'Yearly','Anual'
Insert into TempMetaDataOrgMapping Select 406,'YY','YY'
Insert into TempMetaDataOrgMapping Select 407,'YYY','YYY'
Insert into TempMetaDataOrgMapping Select 408,'Zero With Un-Mapped Services','Sercivio desasignado a cero'
Insert into TempMetaDataOrgMapping Select 409,'Zero-Value services','Servicios Gratis'
Insert into TempMetaDataOrgMapping Select 410,'Zero-Value with mapped Services','Servicio asignado con el valor de cero'
Insert into TempMetaDataOrgMapping Select 411,'0','0'
Insert into TempMetaDataOrgMapping Select 412,'1','1'
Insert into TempMetaDataOrgMapping Select 413,'2','2'
Insert into TempMetaDataOrgMapping Select 414,'3','3'
Insert into TempMetaDataOrgMapping Select 415,'4','4'
Insert into TempMetaDataOrgMapping Select 416,'5','5'
Insert into TempMetaDataOrgMapping Select 417,'6','6'
Insert into TempMetaDataOrgMapping Select 418,'7','7'
Insert into TempMetaDataOrgMapping Select 419,'8','8'
Insert into TempMetaDataOrgMapping Select 420,'9','9'
Insert into TempMetaDataOrgMapping Select 421,'10','10'
Insert into TempMetaDataOrgMapping Select 422,'11','11'
Insert into TempMetaDataOrgMapping Select 423,'12','12'
Insert into TempMetaDataOrgMapping Select 424,'15','15'
Insert into TempMetaDataOrgMapping Select 425,'20','20'
Insert into TempMetaDataOrgMapping Select 426,'21','21'
Insert into TempMetaDataOrgMapping Select 427,'25','25'
Insert into TempMetaDataOrgMapping Select 428,'30','30'
Insert into TempMetaDataOrgMapping Select 429,'40','40'
Insert into TempMetaDataOrgMapping Select 430,'42','42'
Insert into TempMetaDataOrgMapping Select 431,'50','50'
Insert into TempMetaDataOrgMapping Select 432,'-','-'
Insert into TempMetaDataOrgMapping Select 433,'(','('
Insert into TempMetaDataOrgMapping Select 434,')',')'
Insert into TempMetaDataOrgMapping Select 435,'*','*'
Insert into TempMetaDataOrgMapping Select 436,'/','/'
Insert into TempMetaDataOrgMapping Select 437,'^','^'
Insert into TempMetaDataOrgMapping Select 437,'^','^'
Insert into TempMetaDataOrgMapping Select 439,'+','+'
Insert into TempMetaDataOrgMapping Select 440,'<=','<='
Insert into TempMetaDataOrgMapping Select 437,'=','='
Insert into TempMetaDataOrgMapping Select 437,'=>','=>'
Insert into TempMetaDataOrgMapping Select 443,'>','>'
Insert into TempMetaDataOrgMapping Select 444,'A-','A-'
Insert into TempMetaDataOrgMapping Select 445,'A+','A+'
Insert into TempMetaDataOrgMapping Select 446,'A1-','A1-'
Insert into TempMetaDataOrgMapping Select 447,'A1+','A1+'
Insert into TempMetaDataOrgMapping Select 448,'A1B-','A1B-'
Insert into TempMetaDataOrgMapping Select 449,'A1B+','A1B+'
Insert into TempMetaDataOrgMapping Select 450,'A2-','A2-'
Insert into TempMetaDataOrgMapping Select 451,'A2+','A2+'
Insert into TempMetaDataOrgMapping Select 452,'A2B-','A2B-'
Insert into TempMetaDataOrgMapping Select 453,'A2B+','A2B+'
Insert into TempMetaDataOrgMapping Select 454,'AB-','AB-'
Insert into TempMetaDataOrgMapping Select 455,'AB+','AB+'



select *  from MetaDataOrgMapping where OrgID =86 and MetadataID in (select MetaDataid from MetaData )  order by displaytext  asc
--select *  from TempMetadataOrgMapping where sno in (select max(t.sno ) from TempMetadataOrgMapping t inner join TempMetadataOrgMapping t1 on t1.Name =t.Name group by t.Name  having COUNT (t.Name )>1)
--delete from TempMenuMaster where sno in (select max(t.sno ) from TempMetadataOrgMapping t inner join TempMetadataOrgMapping t1 on t1.Name =t.Name group by t.Name  having COUNT (t.Name )>1)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into MetaDataOrgMapping (MetadataID ,OrgID  ,LangCode  ,DisplayText )
select  MM.MetadataID ,MM.OrgID ,@language  ,tbl.ChineseChar from MetaDataOrgMapping MM
inner join TempMetadataOrgMapping tbl on tbl.Name =MM.DisplayText and OrgID =@OrgiD 
where OrgID =@OrgiD 
------------------------------------------------------------------------------------------------------------------------------------
----------------For Salutation Org mapping table------------------------------------------------------------------------------------
drop table TempSalutationOrgmapping
Create table TempSalutationOrgmapping(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000))
Insert into TempSalutationOrgMapping Select'',''
Insert into TempSalutationOrgMapping Select'Baby of.','Bebé de'
Insert into TempSalutationOrgMapping Select'Baby.','Bebé.'
Insert into TempSalutationOrgMapping Select'Brother','Hermano'
Insert into TempSalutationOrgMapping Select'Captain','Capitán'
Insert into TempSalutationOrgMapping Select'Dr.','Dr. (Doctor)'
Insert into TempSalutationOrgMapping Select'Father','Padre'
Insert into TempSalutationOrgMapping Select'Master.','Máster'
Insert into TempSalutationOrgMapping Select'Miss','Señorita'
Insert into TempSalutationOrgMapping Select'Mr.','Señor'
Insert into TempSalutationOrgMapping Select'Mrs.','Señora'
Insert into TempSalutationOrgMapping Select'Ms.','Señora'
Insert into TempSalutationOrgMapping Select'Others','Otros'
Insert into TempSalutationOrgMapping Select'Professor','Profesor'
Insert into TempSalutationOrgMapping Select'Shri.','Shri'
Insert into TempSalutationOrgMapping Select'Sister','Hermana'
Insert into TempSalutationOrgMapping Select'Undisclosed','No divulgable'


declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into SalutationOrgMapping (TitleID ,DisplayText ,LanguageCode ,OrgID ,CreatedBy )
select distinct SM.TitleID ,tbl.ChineseChar  ,@language ,@OrgiD ,SM.CreatedBy from SalutationOrgMapping SM
inner join TempSalutationOrgmapping tbl on tbl.Name =SM.DisplayText and OrgID =@OrgiD 
where OrgID =@OrgiD 


-----------------------------------------------------------------------------------------------------------------------------------
--------------------For ActionManager Type-----------------------------------------------------------------------------------------
drop table TempActionManagerType
Create table TempActionManagerType(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000),ActionCode  Nvarchar(1000))



--Insert into TempActionManagerType Select 'Email','Email','REPEMAIL'
--Insert into TempActionManagerType Select 'RedirectURL','Redireccionar URL','NULL'
--Insert into TempActionManagerType Select 'Sms','SMS','REPSMS'
--Insert into TempActionManagerType Select 'Courier','mensajero','NULL'
--Insert into TempActionManagerType Select 'Hand Delivery','Entrega en mano','NULL'
--Insert into TempActionManagerType Select 'Online','En línea','NULL'
--Insert into TempActionManagerType Select 'Sms/Email','Sms / email','NULL'
--Insert into TempActionManagerType Select 'Postal','Postal','NULL'
--Insert into TempActionManagerType Select 'Pdf','pdf','NULL'
--Insert into TempActionManagerType Select 'Email','Email','REMAIL'
--Insert into TempActionManagerType Select 'Sms','SMS','RSMS'
--Insert into TempActionManagerType Select 'Email','Email','IEMAIL'
--Insert into TempActionManagerType Select 'Sms','SMS','ISMS'
--Insert into TempActionManagerType Select 'Courier','mensajero','Courier'
--Insert into TempActionManagerType Select 'ISSTATPDF','ISSTATPDF','ISSTATPDF'
--Insert into TempActionManagerType Select 'ROUNDBPDF','ROUNDBPDF','ROUNDBPDF'
--Insert into TempActionManagerType Select 'ISSTATPRINT','ISSTATPRINT','ISSTATPRINT'
--Insert into TempActionManagerType Select 'ROUNDBPRINT','ROUNDBPRINT','ROUNDBPRINT'
--Insert into TempActionManagerType Select 'PRINT','IMPRESIÓN','PRINT'
--Insert into TempActionManagerType Select 'BILLPRINT','BILLPRINT','BILLPRINT'

Insert into TempActionManagerType Select 'Email','correo electrónico','REPEMAIL'
Insert into TempActionManagerType Select 'Sms','texto','REPSMS'
Insert into TempActionManagerType Select 'Email','correo electrónico','REMAIL'
Insert into TempActionManagerType Select 'Sms','texto','RSMS'
Insert into TempActionManagerType Select 'Email','correo electrónico','IEMAIL'
Insert into TempActionManagerType Select 'Sms','texto','ISMS'



declare @language nvarchar(20) = 'es-ES'
insert into ActionManagerType(ActionType,IsDisplay,ActionCode,Type,LangCode) 
select distinct tbl.ChineseChar,AM.IsDisplay,AM.ActionCode,AM.Type,@language from ActionManagerType AM
inner join TempActionManagerType tbl on tbl.Name =AM.ActionType
----------------------------------------------------------------------------------------------------------------
------------------------For InvDeptMaster table ----------------------------------------------------------------
drop table TempInvDeptMaster
Create table TempInvDeptMaster(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000))


--Insert into TempInvDeptMaster Select'GENETICS','GENÉTICA'
--Insert into TempInvDeptMaster Select'REFERRED','REFERIDO'
--Insert into TempInvDeptMaster Select'R AND D','R Y D'
--Insert into TempInvDeptMaster Select'MOLECULAR BIOLOGY','BIOLOGÍA MOLECULAR'
--Insert into TempInvDeptMaster Select'CLINICAL CHEMISTRY','QUÍMICA CLÍNICA'
--Insert into TempInvDeptMaster Select'CLINICAL PATHOLOGY','PATOLOGIA CLINICA'
--Insert into TempInvDeptMaster Select'HEALTH CHECKUP','REVISIÓN DE SALUD'
--Insert into TempInvDeptMaster Select'HAEMATOLOGY','HEMATOLOGÍA'
--Insert into TempInvDeptMaster Select'MICROBIOLOGY','MICROBIOLOGÍA'
--Insert into TempInvDeptMaster Select'SEROLOGY','SEROLOGÍA'
--Insert into TempInvDeptMaster Select'SURGICAL PATH','CAMINO QUIRÚRGICO'
--Insert into TempInvDeptMaster Select'BIOCHEMISTRY','BIOQUÍMICA'
--Insert into TempInvDeptMaster Select'IMMUNOASSAY','Inmunoensayo'
--Insert into TempInvDeptMaster Select'SHARED BIOCHEMISTRY','BIOQUÍMICA COMPARTIDA'
--Insert into TempInvDeptMaster Select'CLINICAL TRIALS','ENSAYOS CLÍNICOS'
--Insert into TempInvDeptMaster Select'BREAST PATHOLOGY EXPERT OPINION','MAMA PATOLOGÍA OPINION DE EXPERTOS'
--Insert into TempInvDeptMaster Select'DERMATOPATHOLOGY EXPERT OPINION','DERMATOPATOLOGÍA OPINION DE EXPERTOS'
--Insert into TempInvDeptMaster Select'GI HEPATOBILIARY PATHOLOGY EXPERT OPINION','OPINIÓN GI HEPATOBILIAR PATOLOGÍA DE EXPERTOS'
--Insert into TempInvDeptMaster Select'HEMATOLYMPHOID PATHOLOGY EXPERT OPINION','OPINIÓN hematolinfoides PATOLOGÍA DE EXPERTOS'
--Insert into TempInvDeptMaster Select'PAEDIATRIC PATHOLOGY EXPERT OPINION','PATOLOGÍA DE PEDIATRIA OPINION DE EXPERTOS'
--Insert into TempInvDeptMaster Select'TRANSPLANT PATHOLOGY EXPERT OPINION','TRASPLANTE DE PATOLOGÍA OPINION DE EXPERTOS'
--Insert into TempInvDeptMaster Select'CT','Connecticut'
--Insert into TempInvDeptMaster Select'MRI','RM'
--Insert into TempInvDeptMaster Select'ULTRASOUND','ULTRASONIDO'
--Insert into TempInvDeptMaster Select'X-RAY','RADIOGRAFÍA'
--Insert into TempInvDeptMaster Select'IMMUNOLOGY','INMUNOLOGÍA'
--Insert into TempInvDeptMaster Select'HISTOPATHOLOGY','HISTOPATOLOGÍA'


Insert into TempInvDeptMaster Select'Bacteriology','Bacteriología'
Insert into TempInvDeptMaster Select'Biochemistry','Bioquímica'
Insert into TempInvDeptMaster Select'Clinical Chemistry','Química Clínica'
Insert into TempInvDeptMaster Select'Clinical Pathology','Patología Clínica'
Insert into TempInvDeptMaster Select'Cytology','Citología'
Insert into TempInvDeptMaster Select'Hematalogy','Hematología'
Insert into TempInvDeptMaster Select'Histopathology','Histopatología'
Insert into TempInvDeptMaster Select'Immunoassay','Inmunoanálisis'
Insert into TempInvDeptMaster Select'Microbiology','Microbiología'
Insert into TempInvDeptMaster Select'Serology','Serología'
Insert into TempInvDeptMaster Select'Special Chemistry','Química Especial'

select * from InvDeptMaster where langcode='es-es' and orgid=86

declare @language nvarchar(20) = 'es-ES'
Declare @OrgID bigint=86
insert into invdeptmaster(DeptId,DeptName,Orgid,Display,SequenceNo,DeptCode,Code,LangCode)
select distinct I.DeptId,tbl.ChineseChar ,@OrgID,I.Display,I.SequenceNo,I.DeptCode,I.Code,@language from InvDeptMaster I
inner join TempInvDeptMaster tbl on tbl.Name =I.DeptName and orgid=@OrgID 
where OrgID =@OrgID 

----------------------------------------------------------------------------------------------------------------------------------
---------------For Investigation Sample Container---------------------------------------------------------------------------------
drop table TempInvestigationSampleContainer
Create table TempInvestigationSampleContainer(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempInvestigationsampleContainer Select'Gel Tube','tubo de gel'
Insert into TempInvestigationsampleContainer Select'EDTA','EDTA'
Insert into TempInvestigationsampleContainer Select'Heparin','La heparina'
Insert into TempInvestigationsampleContainer Select'Slide','Diapositiva'
Insert into TempInvestigationsampleContainer Select'Sterile Container','Recipiente estéril'
Insert into TempInvestigationsampleContainer Select'Urine Container','Contenedor de orina'
Insert into TempInvestigationsampleContainer Select'Sodium heparin vacutainer','Heparina sódica vacutainer'
Insert into TempInvestigationsampleContainer Select'Paraffin embeded fixed block','Parafina bloque fijo Embebido'
Insert into TempInvestigationsampleContainer Select'Buccal smear alcohol fixed slides','diapositivas de alcohol frotis bucal fijos'
Insert into TempInvestigationsampleContainer Select'Sterile saline container','recipiente de solución salina estéril'
Insert into TempInvestigationsampleContainer Select'(DEFIBRINATED/ACD/EDTA)','(Desfibrinada / DCA / EDTA)'
Insert into TempInvestigationsampleContainer Select'15 ML OF SPOT URINE','15 ml de orina al azar'
Insert into TempInvestigationsampleContainer Select'2ML FLUOURIDE PLASMAS AT FASTI','2ML FLUOURIDE plasmas EN FASTI'
Insert into TempInvestigationsampleContainer Select'3.2% SODIUM CITRATE PLATELET POOR PLASMA','3.2% CITRATO DE SODIO PLAQUETARIA plasma pobre'
Insert into TempInvestigationsampleContainer Select'3.2% SODIUM CITRATE VACCUTAINER','3.2% CITRATO DE SODIO Vaccutainer'
Insert into TempInvestigationsampleContainer Select'3-4cc  in EDTA Vacutainer','3-4cc en EDTA Vacutainer'
Insert into TempInvestigationsampleContainer Select'ALL SMEARS ON INTACT GLASS SLIDES','Todas las gotas sobre placas de vidrio INTACTOS'
Insert into TempInvestigationsampleContainer Select'BACTEC MYCO F/LYTIC BOTTLE','BACTEC MYCO F / BOTELLA LÍTICO'
Insert into TempInvestigationsampleContainer Select'BACTEC PLUS AEROBIC  BOTTLE','BOTELLA BACTEC PLUS AERÓBICO'
Insert into TempInvestigationsampleContainer Select'BACTEC PLUS AEROBIC AND ANAEROBIC BOTTLE','BACTEC PLUS AEROBIC Y BOTELLA ANAERÓBICO'
Insert into TempInvestigationsampleContainer Select'BACTEC PLUS AEROBIC BOTTLE','BOTELLA BACTEC PLUS AERÓBICO'
Insert into TempInvestigationsampleContainer Select'BACTEC PLUS ANAEROBIC BOTTLE','BOTELLA BACTEC PLUS ANAERÓBICO'
Insert into TempInvestigationsampleContainer Select'BLOCK TISSUE','BLOQUE DE TEJIDOS'
Insert into TempInvestigationsampleContainer Select'BLOCKS','BLOQUES'
Insert into TempInvestigationsampleContainer Select'BLOCKS & SLIDES','BLOQUES Y DESLIZAMIENTOS'
Insert into TempInvestigationsampleContainer Select'BONE MAROW IN SODIUM HEPARIN VACCUTAINER','HUESO EN marow heparina sódica Vaccutainer'
Insert into TempInvestigationsampleContainer Select'BONE MARROW','MÉDULA ÓSEA'
Insert into TempInvestigationsampleContainer Select'BONE MARROW IN EDTA VACCUTAINER','MÉDULA ÓSEA EN EDTA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'BONE MARROW IN SODIUM HEPARIN VACCUTAINER','MÉDULA ÓSEA EN heparina sódica Vaccutainer'
Insert into TempInvestigationsampleContainer Select'CSF IN EDTA VACCUTAINER & IN PLAIN VACCUTAINER','CSF en EDTA Vaccutainer y en la llanura Vaccutainer'
Insert into TempInvestigationsampleContainer Select'CULTURE PLATE/SLANT','Cultivo en placa / INCLINACIÓN'
Insert into TempInvestigationsampleContainer Select'CVS SAMPLE','MUESTRA CVS'
Insert into TempInvestigationsampleContainer Select'DARK LEAKED PROOF CONTAINER','OSCURIDAD A PRUEBA DE FUGAS DE ENVASE'
Insert into TempInvestigationsampleContainer Select'EDTA AND CITRATE SAMPLE','EDTA Y MUESTRA CITRATO'
Insert into TempInvestigationsampleContainer Select'EDTA SMEAR AND SAMPLE REQD','EDTA frotis y MUESTRA REQD'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAIER','EDTA VACCUTAIER'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAIER & 3.2% SODIUM CITRATE VACCUTAINER','EDTA VACCUTAIER y 3.2% CITRATO DE SODIO Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER','EDTA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER  AND DIRECT SMEAR','EDTA Vaccutainer Y frotis directo'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER & DIRECT SMEAR ON SLIDE','EDTA Vaccutainer y frotis directo EN DIAPOSITIVA'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER & PLAIN VACCUTAINER','EDTA Vaccutainer y NORMAL Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER & SMEAR','EDTA Vaccutainer y SMEAR'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER & SMEARS ON INTACT GLASS SLIDES','EDTA Vaccutainer y manchas en portaobjetos de vidrio INTACTOS'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER AND 2 DIRECT SMEARS','EDTA Vaccutainer Y 2 frotis directos'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER AND DIRECT SMEAR','EDTA Vaccutainer Y frotis directo'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER AND PLAIN VACCUTAINER','EDTA Vaccutainer, casquillos de Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER AND SODIUM HEPARIN VACCUTAINER','EDTA Vaccutainer Y heparina sódica Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER OR GEL TUBE','EDTA Vaccutainer O TUBO DE GEL'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER OR PLAIN VACCUTAINER','EDTA Vaccutainer o simplemente Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER OR SODIUM HEPARIN VACCUTAINER','EDTA Vaccutainer O heparina sódica Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER OR SODIUM HEPARINE VACCUTAINER','EDTA Vaccutainer o sodio HEPARINA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER OR SWAB IN STERLIE CONTAINER','EDTA Vaccutainer o hisopo EN EL ENVASE STERLIE'
Insert into TempInvestigationsampleContainer Select'EDTA VACCUTAINER/SODIUM HEPARINE VACCUTAINER','EDTA Vaccutainer / SODIO HEPARINA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'EDTA VACUTAINER','Vacutainer con EDTA'
Insert into TempInvestigationsampleContainer Select'EDTA, FFPE Tissue','EDTA, tejido FFPE'
Insert into TempInvestigationsampleContainer Select'EDTA/ACD','EDTA / ACD'
Insert into TempInvestigationsampleContainer Select'FLOURIDE VACCUTAINER','Flouride Vaccutainer'
Insert into TempInvestigationsampleContainer Select'FLUORIDE VACCUTAINER','FLUOR Vaccutainer'
Insert into TempInvestigationsampleContainer Select'FUNGUS AGAR SLANT','HONGOS de agar inclinado'
Insert into TempInvestigationsampleContainer Select'HEPARIN VACUTAINER','Vacutainer HEPARINA'
Insert into TempInvestigationsampleContainer Select'HEPARINE VACCUTAINER','HEPARINA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'IN STERILE TRANSPORT MEDIUM','En medio de transporte ESTÉRIL'
Insert into TempInvestigationsampleContainer Select'INTACT GLASS SLIDES','Portaobjetos de vidrio INTACTOS'
Insert into TempInvestigationsampleContainer Select'INTACT GLASS SLIDES AND EDTA BLOOD REQD','AVERÍA DE VIDRIO diapositivas y EDTA SANGRE REQD'
Insert into TempInvestigationsampleContainer Select'INTACT GLASS SLIDES REQD,','AVERÍA Diapositivas de vidrio REQD,'
Insert into TempInvestigationsampleContainer Select'LBC CONTAINER','LBC CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'leak proof container','recipiente a prueba de fugas'
Insert into TempInvestigationsampleContainer Select'LEAKED PROOF CONTAINER','FUGAS DE recipiente a prueba'
Insert into TempInvestigationsampleContainer Select'LEAKED PROOF EDTA AND PLAIN CONTAINER','PRUEBA DE FUGAS DE EDTA, casquillos de CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'LEAKPROOF CONTAINER','hermético de CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'METAL FREE CONTAINER','LIBRE DE METAL CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'NA','N / A'
Insert into TempInvestigationsampleContainer Select'NULL','NULO'
Insert into TempInvestigationsampleContainer Select'Placental Tissue=Sterile tissuecontainer with normal saline orculture media, PeripheralBlood=Sodium heparinVacutainer','Tejido placentario = tissuecontainer estéril con medios orculture solución salina normal, PeripheralBlood = Sodio heparinVacutainer'
Insert into TempInvestigationsampleContainer Select'PLAIN CONTAINER','NORMAL CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'PLAIN VACCUTAINER','NORMAL Vaccutainer'
Insert into TempInvestigationsampleContainer Select'PLAIN VACCUTAINER & EDTA VACCUTAINER','NORMAL Vaccutainer y EDTA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'PLAIN VACCUTAINER (WITHOUT GEL)','NORMAL Vaccutainer (SIN GEL)'
Insert into TempInvestigationsampleContainer Select'PLAIN VACCUTAINER / EDTA BLOOD','NORMAL Vaccutainer / sangre con EDTA'
Insert into TempInvestigationsampleContainer Select'PLAIN VACCUTAINER OR EDTA VACCUTAINER','NORMAL Vaccutainer o EDTA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'PLAIN VACCUTAINER WITHOUT GEL','Vaccutainer plano sin GEL'
Insert into TempInvestigationsampleContainer Select'PLAIN VACCUTAINER/ EDTA VACCUTAINER','NORMAL Vaccutainer / EDTA Vaccutainer'
Insert into TempInvestigationsampleContainer Select'PLAIN VACUATINER','NORMAL VACUATINER'
Insert into TempInvestigationsampleContainer Select'PLAIN VACUTAINER','Vacutainer NORMAL'
Insert into TempInvestigationsampleContainer Select'PLAIN VACUTAINER (NOT OPENED, NO GEL)','NORMAL Vacutainer (NO ABIERTO, NO GEL)'
Insert into TempInvestigationsampleContainer Select'PLAIN VACUTAINER , LEAK PRROF CONTAINER','NORMAL Vacutainer, FUGAS prrof CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'PLAIN VACUTINAER','NORMAL VACUTINAER'
Insert into TempInvestigationsampleContainer Select'PURE CULTURE BOTTLE OR TUBE','BOTELLA cultivo puro o tubo'
Insert into TempInvestigationsampleContainer Select'PURE CULTURE PLATE OR SLANT','PLACA cultivo puro o inclinar'
Insert into TempInvestigationsampleContainer Select'RED TOP / GREY TOP','RED TOP / superior gris'
Insert into TempInvestigationsampleContainer Select'Semi-Speciality','Semi-especializado'
Insert into TempInvestigationsampleContainer Select'SMEARS AND HPV VIAL','Papanicolaou y VPH VIAL'
Insert into TempInvestigationsampleContainer Select'SODIUM HEPARIN VACCUTAINER','Heparina sódica Vaccutainer'
Insert into TempInvestigationsampleContainer Select'SODIUM HEPARIN VACCUTAINER AND DIRECT SMEAR REQD','Heparina sódica Vaccutainer Y DIRECTO SMEAR REQD'
Insert into TempInvestigationsampleContainer Select'SODIUM HEPARINE VACCUTAINER','HEPARINA DE SODIO Vaccutainer'
Insert into TempInvestigationsampleContainer Select'SODIUM HEPARINE VACCUTAINER & EDAT VACCUTAINER','HEPARINA DE SODIO Vaccutainer y EDAT Vaccutainer'
Insert into TempInvestigationsampleContainer Select'SPECIAL FILTER PAPER','FILTRO DE PAPEL ESPECIAL'
Insert into TempInvestigationsampleContainer Select'SPECIAL FILTER PAPER (NEONATAL CARD)','FILTRO DE PAPEL ESPECIAL (TARJETA neonatal)'
Insert into TempInvestigationsampleContainer Select'SPECIAL KIT','KIT ESPECIAL'
Insert into TempInvestigationsampleContainer Select'SPECIAL TUBE WITH 8% PERCHLORIC ACID','ESPECIAL CON TUBO 8% PERCLÓRICO ÁCIDO'
Insert into TempInvestigationsampleContainer Select'Speciality','Especialidad'
Insert into TempInvestigationsampleContainer Select'STERILE LEAK PROOF CONTAINER','FUGA ESTÉRIL recipiente a prueba'
Insert into TempInvestigationsampleContainer Select'STERILE LEAKED PROOF CONTAINER','ESTÉRIL A PRUEBA DE FUGAS DE ENVASE'
Insert into TempInvestigationsampleContainer Select'STERILE LEAKPROOF CONTAINER','Recipientes herméticos ESTÉRIL'
Insert into TempInvestigationsampleContainer Select'STRECK TUBE','TUBO STRECK'
Insert into TempInvestigationsampleContainer Select'THIN PREP CONTAINER','THIN PREP CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'UREA BREATH TEST CARD','UREA TARJETA DE PRUEBA DE ALIENTO'
Insert into TempInvestigationsampleContainer Select'_','_'
Insert into TempInvestigationsampleContainer Select'Slides','diapositivas'
Insert into TempInvestigationsampleContainer Select'SLIDES / LBC CONTAINER','DESLIZAMIENTOS / LBC CONTENEDOR'
Insert into TempInvestigationsampleContainer Select'Citrate','Citrato'
Insert into TempInvestigationsampleContainer Select'Culture bottle','botella de cultivo'
Insert into TempInvestigationsampleContainer Select'Neonatal Card','Tarjeta neonatal'
Insert into TempInvestigationsampleContainer Select'EDTA AND heparin VACUTAINER and Direct smears    ','EDTA y heparina VACUTAINER y frotis directos'
Insert into TempInvestigationsampleContainer Select'Smear Slide','frotis'
Insert into TempInvestigationsampleContainer Select'LEAK PROOF DARK CONTAINER','PRUEBA DE FUGAS contenedor oscuro'
Insert into TempInvestigationsampleContainer Select'Plaine vacutainers                                                                                                                                    ','tubos al vacío Plaine'
Insert into TempInvestigationsampleContainer Select'3.2% SODIUM CITRATE VACUTAINER                                                                                                                        ','3.2% Vacutainer CITRATO DE SODIO'
Insert into TempInvestigationsampleContainer Select'PLAIN VACUTAINER (WITHOUT GEL)                                                                                                                        ','NORMAL Vacutainer (SIN GEL)'
Insert into TempInvestigationsampleContainer Select'RED TOP / GREY TOP (Lithium heparin or blood in spcial container)                                                                                     ','TOP ROJO / GRIS TOP (heparina de litio o sangre en un recipiente spcial)'
Insert into TempInvestigationsampleContainer Select'Lithium Hepparin','Hepparin de litio'
Insert into TempInvestigationsampleContainer Select'FLOURIDE VACUTAINER','Vacutainer Flouride'
Insert into TempInvestigationsampleContainer Select'EDTA OR heparin VACUTAINER and Direct smears                                                                                                          ','EDTA o heparina y VACUTAINER frotis directos'
Insert into TempInvestigationsampleContainer Select'EDTA VACUTAINER & SMEAR                                                                                                                               ','Vacutainer con EDTA y SMEAR'
Insert into TempInvestigationsampleContainer Select'EDTA VACUTAINER AND DIRECT SMEAR                                                                                                                      ','Vacutainer con EDTA y el frotis DIRECTO'
Insert into TempInvestigationsampleContainer Select'EDTA VACUTAINER AND PLAIN VACUTAINER                                                                                                                  ','Vacutainer con EDTA Y Vacutainer NORMAL'
Insert into TempInvestigationsampleContainer Select'EDTA VACUTAINER & SMEARS ON INTACT GLASS SLIDES                                                                                                       ','Vacutainer con EDTA y se corre en portaobjetos de vidrio INTACTOS'
Insert into TempInvestigationsampleContainer Select'SEPARATOR VIAL','SEPARADOR VIAL'
Insert into TempInvestigationsampleContainer Select'BLACK','NEGRO'
Insert into TempInvestigationsampleContainer Select'Container','Envase'
Insert into TempInvestigationsampleContainer Select'LAVENDER','LAVANDA'
Insert into TempInvestigationsampleContainer Select'RED','ROJO'
Insert into TempInvestigationsampleContainer Select'RED TOP','RED TOP'
Insert into TempInvestigationsampleContainer Select'REDTOP','REDTOP'
Insert into TempInvestigationsampleContainer Select'FILTER PAPER','PAPEL DE FILTRO'
Insert into TempInvestigationsampleContainer Select'CAPILLARY TUBE','TUBO CAPILAR'
Insert into TempInvestigationsampleContainer Select'NEEDLE PRICK','pinchazo'
Insert into TempInvestigationsampleContainer Select'H & E','ÉL'
Insert into TempInvestigationsampleContainer Select'GLUCOSE BROTH','CALDO DE GLUCOSA'
Insert into TempInvestigationsampleContainer Select'TAUROCHOLATE','taurocolato'



declare @language nvarchar(20) = 'es-ES'
Declare @OrgID bigint=86
insert into InvestigationSampleContainer(SampleContainerID,ContainerName,Description,Code,Active,OrgID,LangCode)
select distinct ISC.SampleContainerID,tbl.ChineseChar ,ISC.Description,ISC.Code,ISC.Active,@OrgID,@language from InvestigationSampleContainer ISC
inner join TempInvestigationSampleContainer tbl on tbl.Name =ISC.ContainerName  and orgid=@OrgID 
where OrgID =@OrgID 
-----------------------------------------------------------------------------------------------------------------------
----------------For InvReasonOrgMapping table--------------------------------------------------------------------------
drop table TempInvReasonOrgMapping
Create table TempInvReasonOrgMapping(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempInvReasonOrgMapping Select'Referance correction','corrección referance'
Insert into TempInvReasonOrgMapping Select'Medical Correlation','Correlación médica'
Insert into TempInvReasonOrgMapping Select'Clotted sample','muestra coagulada'
Insert into TempInvReasonOrgMapping Select'Sample not received (S.N.R)','La muestra no ha recibido (S.N.R)'
Insert into TempInvReasonOrgMapping Select'Wrong sample','muestra incorrecto'
Insert into TempInvReasonOrgMapping Select'Haemolysed sample','muestra de hemolizado'
Insert into TempInvReasonOrgMapping Select'Spot urine instead of 24hrs urine','muestra de orina en lugar de orina de 24 horas'
Insert into TempInvReasonOrgMapping Select'Patient name mismatch on sample & on TRF','Nombre del paciente desajuste en la muestra y en TRF'
Insert into TempInvReasonOrgMapping Select'Patient''s name not mentioned on sample tube','Nombre del paciente no se menciona en el tubo de muestra'
Insert into TempInvReasonOrgMapping Select'Histo sample received in Saline','Histo muestra recibida en Saline'
Insert into TempInvReasonOrgMapping Select'Dry swab received for AFB or anaerobic culture','hisopo seco recibido por la cultura AFB o anaeróbico'
Insert into TempInvReasonOrgMapping Select'Inactivate test code due to discontinue','Inactivar código de prueba debido a descontinuar'
Insert into TempInvReasonOrgMapping Select'Wrong Registration','registro incorrecto'
Insert into TempInvReasonOrgMapping Select'Kit Not Available','Kit no disponible'
Insert into TempInvReasonOrgMapping Select'Test Deactivated','Desactivado prueba'
Insert into TempInvReasonOrgMapping Select'24hrs urine volume not mentioned','el volumen de orina de 24 horas, no se menciona'
Insert into TempInvReasonOrgMapping Select'Fluid/ separated plasma type not mentioned','Tipo de plasma de fluido / separados que no se menciona'
Insert into TempInvReasonOrgMapping Select'Ht & wt not given for Creatinine Clearance test','HT y no en peso determinado para la prueba de aclaramiento de creatinina'
Insert into TempInvReasonOrgMapping Select'Stone type not mentioned','Tipo de piedra no se menciona'
Insert into TempInvReasonOrgMapping Select'Cyclosporine level not mentioned','nivel de la ciclosporina no se menciona'
Insert into TempInvReasonOrgMapping Select'Triple history not given (USG report)','la historia no da Triple (informe de USG)'
Insert into TempInvReasonOrgMapping Select'Test name test code mismatch','Nombre de la prueba código de prueba desajuste'
Insert into TempInvReasonOrgMapping Select'History incomplete for Histopathology','Historia incompleta de Histopatología'
Insert into TempInvReasonOrgMapping Select'Request received through mail hold till time conf.','Solicitud recibida a través de correo bodega hasta conf tiempo.'
Insert into TempInvReasonOrgMapping Select'Age not given for GFR','La edad no da para TFG'
Insert into TempInvReasonOrgMapping Select'Wrong lab taken','laboratorio de los errores cometidos'
Insert into TempInvReasonOrgMapping Select'Wrong test selected','prueba de mal seleccionado'
Insert into TempInvReasonOrgMapping Select'Test want to be cancelled before processing','Prueba quiere ser cancelada antes de su procesamiento'
Insert into TempInvReasonOrgMapping Select'QNS or SNR & test want to cancelled & should','QNS o SNR y la prueba que desee cancelado y debemos'
Insert into TempInvReasonOrgMapping Select'Q.N.S','Q.N.S'
Insert into TempInvReasonOrgMapping Select'Test Result For Sample having Error from Machine','Resultado de la prueba para la muestra que tiene un error de la máquina'
Insert into TempInvReasonOrgMapping Select'Q.N.S For Recheck','Para Volver a revisar Q.N.S'
Insert into TempInvReasonOrgMapping Select'Sample Integrity Questionable/Contaminated','Ejemplo de dudosa integridad / contaminado'
Insert into TempInvReasonOrgMapping Select'Lipemic Sample','Muestra lipémicos'
Insert into TempInvReasonOrgMapping Select'Icteric Sample','Muestra icteric'
Insert into TempInvReasonOrgMapping Select'Cells Degenerated','células degeneradas'
Insert into TempInvReasonOrgMapping Select'Frozen Sample - Thawed','Muestra congelada - descongelada'
Insert into TempInvReasonOrgMapping Select'Cells Degenerated','células degeneradas'
Insert into TempInvReasonOrgMapping Select'Clotted sample','muestra coagulada'
Insert into TempInvReasonOrgMapping Select'Dry swab received for AFB or anaerobic culture','hisopo seco recibido por la cultura AFB o anaeróbico'
Insert into TempInvReasonOrgMapping Select'Frozen Sample - Thawed','Muestra congelada - descongelada'
Insert into TempInvReasonOrgMapping Select'Haemolysed sample','muestra de hemolizado'
Insert into TempInvReasonOrgMapping Select'Histo sample received in Saline','Histo muestra recibida en Saline'
Insert into TempInvReasonOrgMapping Select'Icteric Sample','Muestra icteric'
Insert into TempInvReasonOrgMapping Select'Inactivate test code due to discontinue','Inactivar código de prueba debido a descontinuar'
Insert into TempInvReasonOrgMapping Select'Lipemic Sample','Muestra lipémicos'
Insert into TempInvReasonOrgMapping Select'Medical Correlation','Correlación médica'
Insert into TempInvReasonOrgMapping Select'Patient name mismatch on sample & on TRF','Nombre del paciente desajuste en la muestra y en TRF'
Insert into TempInvReasonOrgMapping Select'Patient''s name not mentioned on sample tube','Nombre del paciente no se menciona en el tubo de muestra'
Insert into TempInvReasonOrgMapping Select'Q.N.S','Q.N.S'
Insert into TempInvReasonOrgMapping Select'Q.N.S For Recheck','Para Volver a revisar Q.N.S'
Insert into TempInvReasonOrgMapping Select'Sample Integrity Questionable/Contaminated','Ejemplo de dudosa integridad / contaminado'
Insert into TempInvReasonOrgMapping Select'Sample not received (S.N.R)','La muestra no ha recibido (S.N.R)'
Insert into TempInvReasonOrgMapping Select'Spot urine instead of 24hrs urine','muestra de orina en lugar de orina de 24 horas'
Insert into TempInvReasonOrgMapping Select'Test Result For Sample having Error from Machine','Resultado de la prueba para la muestra que tiene un error de la máquina'
Insert into TempInvReasonOrgMapping Select'Wrong sample','muestra incorrecto'
Insert into TempInvReasonOrgMapping Select'Duplicate Registration','registro duplicado'
Insert into TempInvReasonOrgMapping Select'New Sample Requested','Nueva muestra solicitaron'
Insert into TempInvReasonOrgMapping Select'Different Time Schedule','Diferente horario de tiempo'
Insert into TempInvReasonOrgMapping Select'Patient Delay','La demora del paciente'
Insert into TempInvReasonOrgMapping Select'Test Request on Hold','Solicitud de pruebas en espera'
Insert into TempInvReasonOrgMapping Select'Patient in Sick','Paciente en la enfermería'
Insert into TempInvReasonOrgMapping Select'Patient Not Available','Paciente no disponible'
Insert into TempInvReasonOrgMapping Select'Inappropriate Container','Contenedor no apropiado'
Insert into TempInvReasonOrgMapping Select'Inappropriate Patient Preparation','Preparación del paciente no apropiado'
Insert into TempInvReasonOrgMapping Select'Test Cancelled','prueba Cancelado'
Insert into TempInvReasonOrgMapping Select'Non-Cooperative Patient','El paciente no cooperantes'
Insert into TempInvReasonOrgMapping Select'Missing Patient','Falta el paciente'
Insert into TempInvReasonOrgMapping Select'CLINICAL TRIALS - DISCOUNTS','ENSAYOS CLÍNICOS - DESCUENTOS'
Insert into TempInvReasonOrgMapping Select'Corporate Alliances','Las alianzas corporativas'
Insert into TempInvReasonOrgMapping Select'Doctors Prescription : Special Request from Doctor','Los médicos Prescripción: Solicitud especial del doctor'
Insert into TempInvReasonOrgMapping Select'Doctors Prescription : mentioning Maximum Discount','Los médicos Prescripción: mencionar máximo descuento'
Insert into TempInvReasonOrgMapping Select'Doctors Prescription : mentioning Minimum Discount','Los médicos Prescripción: mencionar descuento mínimo'
Insert into TempInvReasonOrgMapping Select'Doctors Relative','Los médicos relativos'
Insert into TempInvReasonOrgMapping Select'Doctors Self','Los médicos Auto'
Insert into TempInvReasonOrgMapping Select'Employee reference','referencia empleado'
Insert into TempInvReasonOrgMapping Select'Govt Officials','funcionarios de gbno'
Insert into TempInvReasonOrgMapping Select'Management Approval : CXO','La aprobación de la dirección: CXO'
Insert into TempInvReasonOrgMapping Select'Management Approval : PCH','Aprobación de gestión: PCH'
Insert into TempInvReasonOrgMapping Select'Marketing Camps','campamentos de marketing'
Insert into TempInvReasonOrgMapping Select'Marketing Special Events','La comercialización de Eventos Especiales'
Insert into TempInvReasonOrgMapping Select'Metropolis Employee','Metropolis Empleado'
Insert into TempInvReasonOrgMapping Select'Doctor recommendation','la recomendación del doctor'
Insert into TempInvReasonOrgMapping Select'Metropolis Public Relations','Relaciones Públicas Metropolis'
Insert into TempInvReasonOrgMapping Select'Doctor Self and Immediate family','Ser y médico de la familia inmediata'
Insert into TempInvReasonOrgMapping Select'Metropolis Social Responsibility','Responsabilidad Social Metropolis'
Insert into TempInvReasonOrgMapping Select'Metropolis  Employee close Relative','Metropolis Empleado pariente cercano'
Insert into TempInvReasonOrgMapping Select'Metropolis  Ex-employee','Metropolis Ex-empleado'
Insert into TempInvReasonOrgMapping Select'PANACEA DISCOUNT','DESCUENTO PANACEA'
Insert into TempInvReasonOrgMapping Select'Senior Management Approval','Autorización de la dirección'
Insert into TempInvReasonOrgMapping Select'Government Official','Funcionario de Gobierno'
Insert into TempInvReasonOrgMapping Select'QC - QUALITY CONTROL','QC - CONTROL DE CALIDAD'
Insert into TempInvReasonOrgMapping Select'Rate Correction Discounts','Descuentos tasa de corrección'
Insert into TempInvReasonOrgMapping Select'Recheck Sample','Volver a revisar la Muestra'
Insert into TempInvReasonOrgMapping Select'REGISTRATION ERRORS','ERRORES DE REGISTRO'
Insert into TempInvReasonOrgMapping Select'Repeat Sample','Repita la Muestra'
Insert into TempInvReasonOrgMapping Select'SAMPLE NOT RECEIVED','MUESTRA NO RECIBIDO'
Insert into TempInvReasonOrgMapping Select'Management Approval','Aprobación de gestión'
Insert into TempInvReasonOrgMapping Select'Unable to process','No se puede procesar'
Insert into TempInvReasonOrgMapping Select'Sample Quality Inappropriate','Calidad de muestra inadecuados'
Insert into TempInvReasonOrgMapping Select'Microclot Seen','Visto Microclot'

declare @language nvarchar(20) = 'es-ES'
Declare @OrgID bigint=86
insert into InvReasonOrgMapping(StatusID,ReasonID,ORgID,Displaytext,LangCode)
select distinct IRM.StatusID,IRM.ReasonID,@OrgID,tbl.ChineseChar ,@language from InvReasonOrgMapping IRM
inner join TempInvReasonOrgMapping tbl on tbl.Name =IRM.Displaytext  and orgid=@OrgID 
where OrgID =@OrgID  and LangCode ='en-GB'
------------------------------------------------------------------------------------------------------------------------------
---------------For InvSampleMaster table--------------------------------------------------------------------------------------
drop table TempInvSampleMaster
Create table TempInvSampleMaster(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000))



Insert into TempInvSampleMaster Select'EDTA WB','AEDT Sangre Completa'
Insert into TempInvSampleMaster Select'24 hrs Urine','Orina de 24 horas'
Insert into TempInvSampleMaster Select'Urine','Orina'
Insert into TempInvSampleMaster Select'Serum','Suero'
Insert into TempInvSampleMaster Select'Citrate Plasma','Plasma de Citrato'
Insert into TempInvSampleMaster Select'Superficial incision on the forearm','Incisión superficial en el antebrazo'
Insert into TempInvSampleMaster Select'Blood','Sangre'
Insert into TempInvSampleMaster Select'Semen','Semen'
Insert into TempInvSampleMaster Select'Ascitic fluid','Líquido Ascítico'
Insert into TempInvSampleMaster Select'Synovial fluid','Líquido Sinovial'
Insert into TempInvSampleMaster Select'Pleural fluid','Líquido Pleural'
Insert into TempInvSampleMaster Select'Cerebrospinal fluid','Líquido Cefalorraquídeo'
Insert into TempInvSampleMaster Select'Whole blood','Sangre Completa'
Insert into TempInvSampleMaster Select'Stool','Heces'
Insert into TempInvSampleMaster Select'Papanicolaou Smear (PAP)','Frotis de Papanicolau'
Insert into TempInvSampleMaster Select'Tissue fluid','Líquido Tisular'
Insert into TempInvSampleMaster Select'Citrate Whole Blood','Sangre Completa de Citrato'
Insert into TempInvSampleMaster Select'Sputum','Esputo'
Insert into TempInvSampleMaster Select'Breath','Respiración'
Insert into TempInvSampleMaster Select'Ethylenediaminetetraacetic acid (EDTA) Plasma','Plasma AEDT Ácido Etilendiaminotetraacético'
Insert into TempInvSampleMaster Select'Heparin Whole blood','Sangre Completa de Heparina'
Insert into TempInvSampleMaster Select'Tissue','Tejido'
Insert into TempInvSampleMaster Select'150 Min-Plasma','150 minutos de Plasma'
Insert into TempInvSampleMaster Select'240 Min-Plasma','240 minutos de Plasma'
Insert into TempInvSampleMaster Select'300 Min-Plasma','300 minutos de Plasma'
Insert into TempInvSampleMaster Select'Gall Bladder Stone','Cálculos en la vesícula biliar'
Insert into TempInvSampleMaster Select'Urinary Stone','Cálculos urinarios'
Insert into TempInvSampleMaster Select'Other samples','Otras muestras'
Insert into TempInvSampleMaster Select'Dried blood spot','Gotas de Sangre Seca'

declare @language nvarchar(20) = 'es-ES'
Declare @OrgID bigint=86
insert into invsampleMaster(SampleCode,SampleDesc,Code,Active,OrgID,LangCode)
select distinct ISM.SampleCode,tbl.ChineseChar ,ISM.Code,ISM.Active,@OrgID,@language from InvSampleMaster ISM
inner join TempInvSampleMaster tbl on tbl.Name =ISM.SampleDesc  and orgid=@OrgID 
where OrgID =@OrgID 
----------------------------------------------------------------------------------------------------------------------
------------------For InvStatusOrgMapping-----------------------------------------------------------------------------
drop table TempInvStatusOrgMapping
Create table TempInvStatusOrgMapping(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempInvStatusOrgMapping Select'Paid','Pagado'
Insert into TempInvStatusOrgMapping Select'Completed','Terminado'
Insert into TempInvStatusOrgMapping Select'Reject','Rechazar'
Insert into TempInvStatusOrgMapping Select'Pending','Pendiente'
Insert into TempInvStatusOrgMapping Select'Approve','Aprobar'
Insert into TempInvStatusOrgMapping Select'SampleReceived','SampleReceived'
Insert into TempInvStatusOrgMapping Select'SampleCollected','SampleCollected'
Insert into TempInvStatusOrgMapping Select'OutSource','externalizar'
Insert into TempInvStatusOrgMapping Select'Cancel','Cancelar'
Insert into TempInvStatusOrgMapping Select'Retest','retest'
Insert into TempInvStatusOrgMapping Select'Recheck','Volver a revisar'
Insert into TempInvStatusOrgMapping Select'Validate','Validar'
Insert into TempInvStatusOrgMapping Select'Ordered','Ordenado'
Insert into TempInvStatusOrgMapping Select'Refered','refirió'
Insert into TempInvStatusOrgMapping Select'SampleTransferred','SampleTransferred'
Insert into TempInvStatusOrgMapping Select'Co-authorize','Co-Autorizar'
Insert into TempInvStatusOrgMapping Select'Co-authorized','Co-autorizado'
Insert into TempInvStatusOrgMapping Select'Not given','No dado'
Insert into TempInvStatusOrgMapping Select'PartialyCollected','PartialyCollected'
Insert into TempInvStatusOrgMapping Select'PartiallyCompleted','Parcialmente completado'
Insert into TempInvStatusOrgMapping Select'PartiallyValidated','PartiallyValidated'
Insert into TempInvStatusOrgMapping Select'PartiallyApproved','PartiallyApproved'
Insert into TempInvStatusOrgMapping Select'With Held','con Held'
Insert into TempInvStatusOrgMapping Select'Reflexwithnewsample','Reflexwithnewsample'
Insert into TempInvStatusOrgMapping Select'SampleLoaded','SampleLoaded'
Insert into TempInvStatusOrgMapping Select'Second Opinion','Segunda opinión'
Insert into TempInvStatusOrgMapping Select'Opinion Given','Dada opinión'
Insert into TempInvStatusOrgMapping Select'Reflexwithsamesample','Reflexwithsamesample'
Insert into TempInvStatusOrgMapping Select'ReflexTest','ReflexTest'
Insert into TempInvStatusOrgMapping Select'With-hold Completion','Con retención de Terminación'
Insert into TempInvStatusOrgMapping Select'With-hold Validation','Con retención de validación'
Insert into TempInvStatusOrgMapping Select'With-hold Approval','Con la aprobación de retención'
Insert into TempInvStatusOrgMapping Select'RejectClose','RejectClose'
Insert into TempInvStatusOrgMapping Select'ProblemSample','ProblemSample'


declare @language nvarchar(20) = 'es-ES'
Declare @OrgID bigint=86
insert into InvStatusOrgMapping(InvestigationStatusID,Status,LangCode,OrgID,DisplayText)
select distinct IOM.InvestigationStatusID,IOM.Status,@language,@OrgID,tbl.ChineseChar from InvStatusOrgMapping IOM
inner join TempInvStatusOrgMapping tbl on tbl.Name =IOM.DisplayText  and orgid=@OrgID 
where OrgID =@OrgID 

----------------------------------------------------------------------------------------------------------------------
------------------For MetaValue_Common--------------------------------------------------------------------------------
drop table TempMetaValue_Common
Create table TempMetaValue_Common(Sno int identity (1,1),Name Varchar(1000),ChineseChar  Nvarchar(1000),MetaTypeId int)


Insert into TempMetaValue_Common Select'HOLIDAY','DÍA FERIADO',1
Insert into TempMetaValue_Common Select'NORTH','NORTE',1
Insert into TempMetaValue_Common Select'DIAGNOSTIC CENTRE','CENTRO DE DIAGNÓSTICO',1
Insert into TempMetaValue_Common Select'SOUTH MUMBAI','SUR DE MUMBAI',2
Insert into TempMetaValue_Common Select'DEMOGRAPHIC CHANGES','CAMBIOS DEMOGRÁFICOS',1
Insert into TempMetaValue_Common Select'INAPPROPRIATE APPROVER','AUTORIZADOR INADECUADO',3
Insert into TempMetaValue_Common Select'CHEMIST','QUÍMICO',3
Insert into TempMetaValue_Common Select'LAB','LABORATORIO',7
Insert into TempMetaValue_Common Select'Routine','Rutina',8
Insert into TempMetaValue_Common Select'INCORRECT RECEVING LOCATION','RECIBO EN UBICACIÓN INCORRECTA',10
Insert into TempMetaValue_Common Select'DOCTOR','DOCTOR',11
Insert into TempMetaValue_Common Select'IMAGING CENTRE','CENTRO DE IMAGEN',3
Insert into TempMetaValue_Common Select'EAST','ESTE',3
Insert into TempMetaValue_Common Select'IN','EN',12
Insert into TempMetaValue_Common Select'LEAVE','LICENCIA',3
Insert into TempMetaValue_Common Select'MD PATH','PATOLOGÍA DOCTOR EN MEDICINA',11
Insert into TempMetaValue_Common Select'TEST','PRUEBA',3
Insert into TempMetaValue_Common Select'Corporate','Corporatvo',3
Insert into TempMetaValue_Common Select'HOSPITAL','HOSPITAL',11
Insert into TempMetaValue_Common Select'MEDICAL STORE','TIENDA MÉDICA',3
Insert into TempMetaValue_Common Select'OUTSTATION LAB','LABORATORIO EN ESTACIÓN REMOTA',3
Insert into TempMetaValue_Common Select'Alpha Numeric','Alfanumérico',16
Insert into TempMetaValue_Common Select'CLINIC','CLÍNICA',16
Insert into TempMetaValue_Common Select'PATHOLOGY','PATOLOGÍA',14
Insert into TempMetaValue_Common Select'ONCOLOGY CLINIC','CLÍNICA ONCOLÓGICA',15
Insert into TempMetaValue_Common Select'HEALTH','SALUD',15
Insert into TempMetaValue_Common Select'DIAGNOSTIC CENTRE','CENTRO DE DIAGNÓSTICO',3
Insert into TempMetaValue_Common Select'PAYMENT RECEIVED','PAGO RECIBIDO',16
Insert into TempMetaValue_Common Select'TYPOGRAPHICAL ERROR','ERROR TIPOGRÁFICO',19
Insert into TempMetaValue_Common Select'Thousand Separator','Separador de miles',19
Insert into TempMetaValue_Common Select'REFERENCE RANGE CORRECTION','CORRECCIÓN EN EL RANGO DE REFERENCIA',3
Insert into TempMetaValue_Common Select'Numeric','Numérico',11
Insert into TempMetaValue_Common Select'OUT','FUERA',10
Insert into TempMetaValue_Common Select'TRUST','FONDO',20
Insert into TempMetaValue_Common Select'In vitro fertilisation (IVF) CENTRE','CENTRO de Fertilización In Vitro (FIV)',21
Insert into TempMetaValue_Common Select'RESULT','RESULTADO',21
Insert into TempMetaValue_Common Select'HEALTH CHECKUP','REVISIÓN MÉDICA',16
Insert into TempMetaValue_Common Select'Walkin','Ambulante',4
Insert into TempMetaValue_Common Select'MOUNT','GENERAR',4
Insert into TempMetaValue_Common Select'Panel','PANEL',4
Insert into TempMetaValue_Common Select'Direct','DIRECTO',4
Insert into TempMetaValue_Common Select'NORTHEAST','NORESTE',4
Insert into TempMetaValue_Common Select'center','Centro',4
Insert into TempMetaValue_Common Select'MD HAEMATOLOGY, ONCOLOGY','DOCTOR EN MEDICINA HEMATOLOGÍA, ONCOLOGÍA',4
Insert into TempMetaValue_Common Select'COLLECTION CENTER','CENTRO DE RECOGIDA',4
Insert into TempMetaValue_Common Select'ILD','Enfermedad pulmonar intersticial (EPI)',4
Insert into TempMetaValue_Common Select'CAMP','CAMPO',4
Insert into TempMetaValue_Common Select'PROCESSING CENTER','CENTRO DE PROCESAMIENTO',4
Insert into TempMetaValue_Common Select'CHANGE IN CLIENT CODE','CAMBIO EN CÓDIGO DEL CLIENTE',4
Insert into TempMetaValue_Common Select'SOUTH','SUR',4
Insert into TempMetaValue_Common Select'FRANCHISEE','FRANQUICIA',4
Insert into TempMetaValue_Common Select'Special','Especial',4
Insert into TempMetaValue_Common Select'DEPARTMENT NAME UPDATION','ACTUALIZACIÓN DE NOMBRE DEL DEPARTAMENTO',4
Insert into TempMetaValue_Common Select'MEDICAL CORRECTION','CORRECCIÓN MÉDICA',4
Insert into TempMetaValue_Common Select'EAST WEST','ESTE OESTE',4
Insert into TempMetaValue_Common Select'KIDNEY CARE CENTRE','CENTRO DE CUIDADO DEL RIÑÓN',4
Insert into TempMetaValue_Common Select'MICRO POSITIVE CULTURE','CULTIVO MICROPOSITIVO',4
Insert into TempMetaValue_Common Select'health check up','REVISIÓN MÉDICA',4
Insert into TempMetaValue_Common Select'COSMETIC AND PLASTIC SURGERY','CIRUGÍA PLÁSTICA Y COSMÉTICA',4
Insert into TempMetaValue_Common Select'HEALTH CHECK UP MARKETING','MERCADEO DE REVISIÓN MÉDICA',4
Insert into TempMetaValue_Common Select'HEALTHCHECKUP TREATMENT','TRATAMIENTO DE REVISIÓN MÉDICA',4
Insert into TempMetaValue_Common Select'InHouse','INTERNO',4
Insert into TempMetaValue_Common Select'NURSING HOME','ASILO DE ANCIANOS',4
Insert into TempMetaValue_Common Select'LAB TO LAB','LABORATORIO A LABORATORIO',4
Insert into TempMetaValue_Common Select'TECHNICAL AND TESTING ANALYSIS','PRUEBAS Y ANÁLISIS TÉCNICOS',4
Insert into TempMetaValue_Common Select'CREDITPENDING','CRÉDITO PENDIENTE',4
Insert into TempMetaValue_Common Select'ADDENDUM','APÉNDICE',4
Insert into TempMetaValue_Common Select'CT Hrs','HORAS DEL TAC',4
Insert into TempMetaValue_Common Select'WEST','OESTE',4
Insert into TempMetaValue_Common Select'OutSource','Subcontratar',4
Insert into TempMetaValue_Common Select'REVENUE','INGRESO',4

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
--select * from MetaValue_Common where orgid=86 and LangCode ='es-es'

insert into MetaValue_Common(MetaTypeId ,Value ,Code ,OrgID ,Description ,IsActive ,LangCode )
select distinct D.MetaTypeId ,tbl.ChineseChar,d.Code,@OrgiD,d.Description,d.IsActive,@language from MetaValue_Common D
inner join TempMetaValue_Common tbl on tbl.Name =D.Value   and OrgID =@OrgiD  and d.langcode='en-gb' and isactive='Y'
where OrgID =@OrgiD 

-----------------------------------------------------------------------------------------------------------------------------------------
----------------Discount MAster----------------------------------------------------------------------------------------------------------
Drop table TempDiscountMaster
Create table TempDiscountMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempDiscountMaster Select '10% - EX EMPLOYEE','10 % EX EMPLEADO'
Insert into TempDiscountMaster Select '70% - EMPLOYEE','70 % EMPLEADO'
Insert into TempDiscountMaster Select '20% - GOVERNMENT HOSPITAL PATIENT','20% PACIENTE DE HOSPITAL GUBERNAMENTAL'
Insert into TempDiscountMaster Select 'ACCREDITATION DISCOUNT','DESCUENTO POR ACREDITACIÓN'
Insert into TempDiscountMaster Select 'Senior Citizen','Adulto Mayor'
Insert into TempDiscountMaster Select '20% - EMPLOYEE REFERENCE SPECIAL','20% - REFERENCIADO ESPECIAL DEL EMPLEADO'
Insert into TempDiscountMaster Select '10% - MY CARD','10% - MI TARJETA'
Insert into TempDiscountMaster Select '12.5% - DOCTOR RECOMMENDATION','12.5% - RECOMENDADO DEL DOCTOR'
Insert into TempDiscountMaster Select '25% - DOCTOR SELF & IMMEDIATE FAMILY','25% - EL DOCTOR MISMO & FAMILIA INMEDIATA'
Insert into TempDiscountMaster Select 'COMPREHENSIVE HEALTH PACKAGE','PAQUETE DE SALUD INTEGRAL'
Insert into TempDiscountMaster Select '15% - SENIOR CITIZEN','15% - ADULTO MAYOR'
Insert into TempDiscountMaster Select 'SPECIAL CORPORATE DISCOUNT','DESCUENTO CORPORATIVO ESPECIAL'

--select * from DiscountMaster where orgid=86

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into DiscountMaster(DiscountName  ,OrgID   ,Discount,discountPercentage ,Code,LangCode  )
select distinct tbl.ChineseChar  ,@OrgiD,D.Discount,D.discountPercentage ,D.Code,@language from DiscountMaster D
inner join TempDiscountMaster tbl on tbl.Name =D.discountName  and OrgID =@OrgiD 
where OrgID =@OrgiD 
-------------------------------------------------------------------------------------------------------------------------
----------------Tax MAster----------------------------------------------------------------------------------------------------------
Drop table TempTaxMaster
Create table TempTaxMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempTaxMaster Select 'Cess Tax','Impuesto Parafiscal'
--Insert into TempTaxMaster Select 'Corporate Tax','Impuesto de Sociedades'
--Insert into TempTaxMaster Select 'Higher Education Cess Tax','Impuesto Parafiscal la Educación Superior'
--Insert into TempTaxMaster Select 'Others','Otros'
--Insert into TempTaxMaster Select 'Service Tax','Impuesto sobre los servicios'
Insert into TempTaxMaster Select 'Value Added Tax','Impuesto al Valor Agregado'


select * from taxmaster where orgid=86

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into Taxmaster (TaxName,TaxPercent,OrgID ,ActiveYN  ,Code,LangCode ,ReferenceType )
select distinct tbl.ChineseChar ,D.TaxPercent    ,@OrgiD ,D.ActiveYN  ,D.Code,@language,ReferenceType from taxmaster D
inner join TempTaxMaster tbl on tbl.Name =D.TaxName  and OrgID =@OrgiD 
where OrgID =@OrgiD 
-------------------------------------------------------------------------------------------------------------------------
----------------Inv Client type----------------------------------------------------------------------------------------------------------
Drop table TempInvClientType
Create table TempInvClientType(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempInvClientType Select 'Business to Business Lab','Laboratorio Negocio a Negocio'
Insert into TempInvClientType Select 'Collection Centers','Centros de Recogida'
Insert into TempInvClientType Select 'Corporate','Empresarial'
Insert into TempInvClientType Select 'Direct phlebotomist','Flebotomista Inmediato'
Insert into TempInvClientType Select 'Franchise','Franquicia'
Insert into TempInvClientType Select 'Lab to Lab','Laboratorio a Laboratorio'
Insert into TempInvClientType Select 'Percentage','Porcentaje'
Insert into TempInvClientType Select 'Referring Hospital','Hospital que refiere'
Insert into TempInvClientType Select 'Referring Physician','Médico que refiere'
Insert into TempInvClientType Select 'Schemes','Esquemas'
Insert into TempInvClientType Select 'Special Rate','Tarifa Especial'
Insert into TempInvClientType Select 'WalkIn','Accesible'


declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into InvClientType (ClientTypeID ,ClientTypeName ,IsInternal,ClientTypeCode,Display,LangCode)
select distinct ClientTypeID, tbl.ChineseChar ,IsInternal,ClientTypeCode,Display,@language from InvClientType D
inner join TempInvClientType tbl on tbl.Name =D.ClientTypeName  --and OrgID =@OrgiD 
--where OrgID =@OrgiD 
-------------------------------------------------------------------------------------------------------------------------
----------------Currency Master----------------------------------------------------------------------------------------------------------
delete from  CurrencyMaster 

Insert into CurrencyMaster Select 1,'ALL','Albanian Lek','Lek albanés'
Insert into CurrencyMaster Select 2,'DZD','Algerian Dinar','Dinar argelino'
Insert into CurrencyMaster Select 3,'XAL','Aluminium Ounces','Onzas de aluminio'
Insert into CurrencyMaster Select 4,'ARS','Argentine Peso','Peso argentino'
Insert into CurrencyMaster Select 5,'AWG','Aruba Florin','Florín arubeño'
Insert into CurrencyMaster Select 6,'AUD','Australian Dollar','Dólar australiano'
Insert into CurrencyMaster Select 7,'BSD','Bahamian Dollar','Dólar de las Bahamas'
Insert into CurrencyMaster Select 8,'BHD','Bahraini Dinar','Dinar bahreiní38'
Insert into CurrencyMaster Select 9,'BDT','Bangladesh Taka','Taka bangladeshí'
Insert into CurrencyMaster Select 10,'BBD','Barbados Dollar','Dólar de Barbados'
Insert into CurrencyMaster Select 11,'BYR','Belarus Ruble','Rublo bielorruso'
Insert into CurrencyMaster Select 12,'BZD','Belize Dollar','Dólar beliceño'
Insert into CurrencyMaster Select 13,'BMD','Bermuda Dollar','Dólar bermudeño'
Insert into CurrencyMaster Select 14,'BTN','Bhutan Ngultrum','Ngultrum butanés'
Insert into CurrencyMaster Select 15,'BOB','Bolivian Boliviano','Boliviano'
Insert into CurrencyMaster Select 16,'BWP','Botswana Pula','Pula'
Insert into CurrencyMaster Select 17,'BRL','Brazilian Real','Real brasileño'
Insert into CurrencyMaster Select 18,'GBP','British Pound','Libra Esterlina'
Insert into CurrencyMaster Select 19,'BND','Brunei Dollar','Dólar de Brunéi'
Insert into CurrencyMaster Select 20,'BGN','Bulgarian Lev','Lev búlgaro'
Insert into CurrencyMaster Select 21,'BIF','Burundi Franc','Franco de Burundi'
Insert into CurrencyMaster Select 22,'KHR','Cambodia Riel','Riel camboyano'
Insert into CurrencyMaster Select 23,'CAD','Canadian Dollar','Dólar canadiense'
Insert into CurrencyMaster Select 24,'CVE','Cape Verde Escudo','Escudo caboverdiano'
Insert into CurrencyMaster Select 25,'KYD','Cayman Islands Dollar','Dólar de las Islas Caimán'
Insert into CurrencyMaster Select 26,'XOF','CFA Franc','Franco CFA de África Central'
Insert into CurrencyMaster Select 27,'XAF','CFA Franc','Franco CFA de África Central'
Insert into CurrencyMaster Select 28,'CLP','Chilean Peso','Peso chileno'
Insert into CurrencyMaster Select 29,'CNY','Chinese Yuan','Yuan chino'
Insert into CurrencyMaster Select 30,'COP','Colombian Peso','Peso colombiano'
Insert into CurrencyMaster Select 31,'KMF','Comoros Franc','Franco comorano'
Insert into CurrencyMaster Select 32,'XCP','Copper Ounces','Onzas de cobre'
Insert into CurrencyMaster Select 33,'CRC','Costa Rica Colon','Colón costarricense'
Insert into CurrencyMaster Select 34,'HRK','Croatian Kuna','Kuna croata'
Insert into CurrencyMaster Select 35,'CUP','Cuban Peso','Peso cubano'
Insert into CurrencyMaster Select 36,'CYP','Cyprus Pound','Libra de Chipre'
Insert into CurrencyMaster Select 37,'CZK','Czech Koruna','Corona checa'
Insert into CurrencyMaster Select 38,'DKK','Danish Krone','Corona danesa'
Insert into CurrencyMaster Select 39,'DJF','Dijibouti Franc','Franco de Djibouti'
Insert into CurrencyMaster Select 40,'DOP','Dominican Peso','Peso dominicano'
Insert into CurrencyMaster Select 41,'XCD','East Caribbean Dollar','Dólar del Caribe Oriental'
Insert into CurrencyMaster Select 42,'ECS','Ecuador Sucre','Sucre ecuatoriano'
Insert into CurrencyMaster Select 43,'EGP','Egyptian Pound','Libra egipcia'
Insert into CurrencyMaster Select 44,'SVC','El Salvador Colon','Colón salvadoreño'
Insert into CurrencyMaster Select 45,'ERN','Eritrea Nakfa','Nakfa'
Insert into CurrencyMaster Select 46,'EEK','Estonian Kroon','Corona de estonia'
Insert into CurrencyMaster Select 47,'ETB','Ethiopian Birr','Birr etíope'
Insert into CurrencyMaster Select 48,'EUR','Euro','Euro'
Insert into CurrencyMaster Select 49,'FKP','Falkland Islands Pound','Libra malvinense'
Insert into CurrencyMaster Select 50,'FJD','Fiji Dollar','Dólar fiyiano'
Insert into CurrencyMaster Select 51,'GMD','Gambian Dalasi','Dalasi'
Insert into CurrencyMaster Select 52,'GHC','Ghanian Cedi','Cedi'
Insert into CurrencyMaster Select 53,'GIP','Gibraltar Pound','Libra gibraltareña'
Insert into CurrencyMaster Select 54,'XAU','Gold Ounces','Onzas de oro'
Insert into CurrencyMaster Select 55,'GTQ','Guatemala Quetzal','Quetzal guatemalteco'
Insert into CurrencyMaster Select 56,'GNF','Guinea Franc','Franco guineano'
Insert into CurrencyMaster Select 57,'GYD','Guyana Dollar','Dólar guyanés'
Insert into CurrencyMaster Select 58,'HTG','Haiti Gourde','Gourde haitiano'
Insert into CurrencyMaster Select 59,'HNL','Honduras Lempira','Lempira hondureño'
Insert into CurrencyMaster Select 60,'HKD','Hong Kong Dollar','Dólar de Hong Kong'
Insert into CurrencyMaster Select 61,'HUF','Hungarian Forint','Forinto húngaro'
Insert into CurrencyMaster Select 62,'ISK','Iceland Krona','Corona islandesa'
Insert into CurrencyMaster Select 63,'INR','Indian Rupee','Rupia india'
Insert into CurrencyMaster Select 64,'IDR','Indonesian Rupiah','Rupia indonesia'
Insert into CurrencyMaster Select 65,'IRR','Iran Rial','Rial iraní'
Insert into CurrencyMaster Select 66,'IQD','Iraqi Dinar','Dinar iraquí'
Insert into CurrencyMaster Select 67,'ILS','Israeli Shekel','Shequel Israelí'
Insert into CurrencyMaster Select 68,'JMD','Jamaican Dollar','Dólar jamaiquino'
Insert into CurrencyMaster Select 69,'JPY','Japanese Yen','Yen'
Insert into CurrencyMaster Select 70,'JOD','Jordanian Dinar','Dinar jordano'
Insert into CurrencyMaster Select 71,'KZT','Kazakhstan Tenge','Tenge kazajo'
Insert into CurrencyMaster Select 72,'KES','Kenyan Shilling','Chelín keniano'
Insert into CurrencyMaster Select 73,'KRW','Korean Won','Wŏn coreano'
Insert into CurrencyMaster Select 74,'KWD','Kuwaiti Dinar','Dinar kuwaití'
Insert into CurrencyMaster Select 75,'LAK','Lao Kip','Kip laosiano'
Insert into CurrencyMaster Select 76,'LVL','Latvian Lat','Lat letón'
Insert into CurrencyMaster Select 77,'LBP','Lebanese Pound','Libra libanesa'
Insert into CurrencyMaster Select 78,'LSL','Lesotho Loti','Loti'
Insert into CurrencyMaster Select 79,'LRD','Liberian Dollar','Dólar liberiano'
Insert into CurrencyMaster Select 80,'LYD','Libyan Dinar','Dinar libio'
Insert into CurrencyMaster Select 81,'LTL','Lithuanian Lita','Lita lituana'
Insert into CurrencyMaster Select 82,'MOP','Macau Pataca','Pataca macaense'
Insert into CurrencyMaster Select 83,'MKD','Macedonian Denar','Denar macedonio'
Insert into CurrencyMaster Select 84,'MGF','Malagasy Franc','Franco malgache'
Insert into CurrencyMaster Select 85,'MWK','Malawi Kwacha','Kwacha de Malaui'
Insert into CurrencyMaster Select 86,'MYR','Malaysian Ringgit','Ringgit malayo'
Insert into CurrencyMaster Select 87,'MVR','Maldives Rufiyaa','Rupia de Maldivas'
Insert into CurrencyMaster Select 88,'MTL','Maltese Lira','Lira Maltesa'
Insert into CurrencyMaster Select 89,'MRO','Mauritania Ougulya','Uguiya'
Insert into CurrencyMaster Select 90,'MUR','Mauritius Rupee','Rupia de Mauricio'
Insert into CurrencyMaster Select 91,'MXN','Mexican Peso','Peso Mexicano'
Insert into CurrencyMaster Select 92,'MDL','Moldovan Leu','Leu moldavo'
Insert into CurrencyMaster Select 93,'MNT','Mongolian Tugrik','Tugrik mongol'
Insert into CurrencyMaster Select 94,'MAD','Moroccan Dirham','Dirham marroquí'
Insert into CurrencyMaster Select 95,'MZM','Mozambique Metical','Metical mozambiqueño'
Insert into CurrencyMaster Select 96,'MMK','Myanmar Kyat','Kyat birmano'
Insert into CurrencyMaster Select 97,'NAD','Namibian Dollar','Dólar namibio'
Insert into CurrencyMaster Select 98,'NPR','Nepalese Rupee','Rupia nepalí'
Insert into CurrencyMaster Select 99,'ANG','Neth Antilles Guilder','Guilder antillano'
Insert into CurrencyMaster Select 100,'TRY','New Turkish Lira','Lira turca'
Insert into CurrencyMaster Select 101,'NZD','New Zealand Dollar','Dólar neozelandés'
Insert into CurrencyMaster Select 102,'ZWN','New Zimbabwe Dollar','Dólar zimbabuense'
Insert into CurrencyMaster Select 103,'NIO','Nicaragua Cordoba','Córdoba nicaragüense'
Insert into CurrencyMaster Select 104,'NGN','Nigerian Naira','Naira'
Insert into CurrencyMaster Select 105,'KPW','North Korean Won','Wŏn norcoreano'
Insert into CurrencyMaster Select 106,'NOK','Norwegian Krone','Corona noruega'
Insert into CurrencyMaster Select 107,'OMR','Omani Rial','Rial omaní'
Insert into CurrencyMaster Select 108,'XPF','Pacific Franc','Franco del pacífico'
Insert into CurrencyMaster Select 109,'PKR','Pakistani Rupee','Rupia pakistaní'
Insert into CurrencyMaster Select 110,'XPD','Palladium Ounces','Onzas de paladio'
Insert into CurrencyMaster Select 111,'PAB','Panama Balboa','Balboa panameño'
Insert into CurrencyMaster Select 112,'PGK','Papua New Guinea Kina','Kina'
Insert into CurrencyMaster Select 113,'PYG','Paraguayan Guarani','Guaraní'
Insert into CurrencyMaster Select 114,'PEN','Peruvian Nuevo Sol','Nuevo sol'
Insert into CurrencyMaster Select 115,'PHP','Philippine Peso','Peso filipino'
Insert into CurrencyMaster Select 116,'XPT','Platinum Ounces','Onzas de Platino'
Insert into CurrencyMaster Select 117,'PLN','Polish Zloty','Złoty'
Insert into CurrencyMaster Select 118,'QAR','Qatar Rial','Riyal qatarí'
Insert into CurrencyMaster Select 119,'ROL','Romanian Leu','Leu rumano'
Insert into CurrencyMaster Select 120,'RON','Romanian New Leu','Nuevo Leu romano'
Insert into CurrencyMaster Select 121,'RUB','Russian Rouble','Rublo ruso'
Insert into CurrencyMaster Select 122,'RWF','Rwanda Franc','Franco ruandés'
Insert into CurrencyMaster Select 123,'WST','Samoa Tala','Tala'
Insert into CurrencyMaster Select 124,'STD','Sao Tome Dobra','Dobra'
Insert into CurrencyMaster Select 125,'SAR','Saudi Arabian Riyal','Riyal saudí'
Insert into CurrencyMaster Select 126,'SCR','Seychelles Rupee','Rupia de Seychelles'
Insert into CurrencyMaster Select 127,'SLL','Sierra Leone Leone','Leone'
Insert into CurrencyMaster Select 128,'XAG','Silver Ounces','Onzas de plata'
Insert into CurrencyMaster Select 129,'SGD','Singapore Dollar','Dólar de Singapur'
Insert into CurrencyMaster Select 130,'SKK','Slovak Koruna','Corona eslovaca'
Insert into CurrencyMaster Select 131,'SIT','Slovenian Tolar','Tolar esloveno'
Insert into CurrencyMaster Select 132,'SBD','Solomon Islands Dollar','Dólar de las Islas Salomón'
Insert into CurrencyMaster Select 133,'SOS','Somali Shilling','Chelín somalí'
Insert into CurrencyMaster Select 134,'ZAR','South African Rand','Rand sudafricano'
Insert into CurrencyMaster Select 135,'LKR','Sri Lanka Rupee','Rupia de Sri Lanka'
Insert into CurrencyMaster Select 136,'SHP','St Helena Pound','Libra de Santa Helena'
Insert into CurrencyMaster Select 137,'SDD','Sudanese Dinar','Dinar sudanés'
Insert into CurrencyMaster Select 138,'SRG','Surinam Guilder','Florín'
Insert into CurrencyMaster Select 139,'SZL','Swaziland Lilageni','Lilangeni'
Insert into CurrencyMaster Select 140,'SEK','Swedish Krona','Corona sueca'
Insert into CurrencyMaster Select 141,'CHF','Swiss Franc','Franco suizo'
Insert into CurrencyMaster Select 142,'SYP','Syrian Pound','Libra siria'
Insert into CurrencyMaster Select 143,'TWD','Taiwan Dollar','Nuevo dólar taiwanés'
Insert into CurrencyMaster Select 144,'TZS','Tanzanian Shilling','Chelín tanzano'
Insert into CurrencyMaster Select 145,'THB','Thai Baht','Baht tailandés'
Insert into CurrencyMaster Select 146,'TOP','Tonga Paanga','Paʻanga'
Insert into CurrencyMaster Select 147,'TTD','Trinidad and Tobago Dollar','Dólar trinitense'
Insert into CurrencyMaster Select 148,'TND','Tunisian Dinar','Dinar tunecino'
Insert into CurrencyMaster Select 149,'USD','U.S. Dollar','Dólar estadounidense'
Insert into CurrencyMaster Select 150,'AED','UAE Dirham','Dirham de los Emiratos Árabes Unidos'
Insert into CurrencyMaster Select 151,'UGX','Ugandan Shilling','Chelín ugandés'
Insert into CurrencyMaster Select 152,'UAH','Ukraine Hryvnia','Grivna'
Insert into CurrencyMaster Select 153,'UYU','Uruguayan New Peso','Peso uruguayo'
Insert into CurrencyMaster Select 154,'VUV','Vanuatu Vatu','Vatu'
Insert into CurrencyMaster Select 155,'VEB','Venezuelan Bolivar','Bolívar'
Insert into CurrencyMaster Select 156,'VND','Vietnam Dong','Dong vietnamita'
Insert into CurrencyMaster Select 157,'YER','Yemen Riyal','Rial yemení'
Insert into CurrencyMaster Select 158,'ZMK','Zambian Kwacha','Kwacha zambiano'
Insert into CurrencyMaster Select 159,'ZWD','Zimbabwe Dollar','Dólar zimbabuense'
-------------------------------------------------------------------------------------------------------------------------
---------------------------Country---------------------------------------------------------------------------------------
Drop table TempCountry
Create table TempCountry([CountryName] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[Nationality] [nvarchar](75) NULL,
	[NationalityID] [smallint] NULL,
	[SNo] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[CountryID] [smallint] NULL,
	[IsDefault] [nchar](1) NULL,
	[ISDCode] [int] NULL,
	[CountryCode] [int] NULL,
	[PhoneNo_Length] [int] NULL)

Insert into TempCountry(CountryName,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,Nationality,NationalityID,CountryID,IsDefault,ISDCode,CountryCode,PhoneNo_Length)
Select distinct CountryName,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,Nationality,NationalityID,CountryID,IsDefault,ISDCode,CountryCode,PhoneNo_Length from country

Drop table Temp_country
Create table Temp_country(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))
Insert into Temp_country Select 'Afghanistan','Afganistán'
Insert into Temp_country Select 'Albania','Albania'
Insert into Temp_country Select 'Algeria','Argelia'
Insert into Temp_country Select 'Andorra','Andorra'
Insert into Temp_country Select 'Angola','Angola'
Insert into Temp_country Select 'Antigua and Barbuda','Antigua y Barbuda'
Insert into Temp_country Select 'Argentina','Argentina'
Insert into Temp_country Select 'Armenia','Armenia'
Insert into Temp_country Select 'Australia','Aruba'
Insert into Temp_country Select 'Austria','Australia'
Insert into Temp_country Select 'Azerbaijan','Azerbayán'
Insert into Temp_country Select 'Bahrain','Baréin, Bahrein'
Insert into Temp_country Select 'Bangladesh','Bangladés, Bangladesh'
Insert into Temp_country Select 'Barbados','Barbados'
Insert into Temp_country Select 'Belarus','Bielorrusia, Belarús'
Insert into Temp_country Select 'Belgium','Bélgica'
Insert into Temp_country Select 'Belize','Belice'
Insert into Temp_country Select 'Benin','Benín'
Insert into Temp_country Select 'Bhutan','Bután'
Insert into Temp_country Select 'Bolivia','Bolivia'
Insert into Temp_country Select 'Bosnia and Herzegovina','Bosnia y Herzegovina'
Insert into Temp_country Select 'Botswana','Botsuana'
Insert into Temp_country Select 'Brazil','Brasil'
Insert into Temp_country Select 'Brunei','Brunéi'
Insert into Temp_country Select 'Bulgaria','Bulgaria'
Insert into Temp_country Select 'Burkina','Burkina Faso'
Insert into Temp_country Select 'Burundi','Burundi'
Insert into Temp_country Select 'Cambodia','Camboya'
Insert into Temp_country Select 'Cameroon','Camerún'
Insert into Temp_country Select 'Canada','Canadá'
Insert into Temp_country Select 'Cape Verde','Cabo Verde'
Insert into Temp_country Select 'Central African Republic','República Centroafricana'
Insert into Temp_country Select 'Chad','Chad'
Insert into Temp_country Select 'Chile','Chile'
Insert into Temp_country Select 'China','China'
Insert into Temp_country Select 'Colombia','Colombia'
Insert into Temp_country Select 'Comoros','Comores'
Insert into Temp_country Select 'Congo','República Democrática del Congo'
Insert into Temp_country Select 'Costa Rica','Costa Rica'
Insert into Temp_country Select 'Cote d''Ivoire','Costa de Marfil'
Insert into Temp_country Select 'Croatia','Croacia'
Insert into Temp_country Select 'Cuba','Cuba'
Insert into Temp_country Select 'Cyprus','Chipre'
Insert into Temp_country Select 'Czech Republic','República Checa'
Insert into Temp_country Select 'Denmark','Dinamarca'
Insert into Temp_country Select 'Djibouti','Yibuti'
Insert into Temp_country Select 'Dominica','Mancomunidad de Dominica'
Insert into Temp_country Select 'Dominican Republic','República Dominicana'
Insert into Temp_country Select 'East Timor','Timor Oriental'
Insert into Temp_country Select 'Ecuador','Ecuador'
Insert into Temp_country Select 'Egypt','Egipto'
Insert into Temp_country Select 'El Salvador','El Salvador'
Insert into Temp_country Select 'Equatorial Guinea','Guinea Ecuatorial'
Insert into Temp_country Select 'Eritrea','Eritrea'
Insert into Temp_country Select 'Estonia','Estonia'
Insert into Temp_country Select 'Ethiopia','Etiopía'
Insert into Temp_country Select 'Federated States of Micronesia','Los Estados Federados de Micronesia'
Insert into Temp_country Select 'Fiji','República de Fiyi'
Insert into Temp_country Select 'Finland','Finlandia'
Insert into Temp_country Select 'France','Francia'
Insert into Temp_country Select 'Gabon','Gabón'
Insert into Temp_country Select 'Georgia','Georgia'
Insert into Temp_country Select 'Germany','Alemania'
Insert into Temp_country Select 'Ghana','Gana'
Insert into Temp_country Select 'Greece','Grecia'
Insert into Temp_country Select 'Grenada','Granada'
Insert into Temp_country Select 'Guatemala','Guatemala'
Insert into Temp_country Select 'Guinea','Guinea'
Insert into Temp_country Select 'Guyana','Guyana'
Insert into Temp_country Select 'Haiti','Haití'
Insert into Temp_country Select 'Honduras','Honduras'
Insert into Temp_country Select 'Hungary','Hungria'
Insert into Temp_country Select 'Iceland','Islandia'
Insert into Temp_country Select 'India','India'
Insert into Temp_country Select 'Indonesia','Indonesia'
Insert into Temp_country Select 'Iran','Irán'
Insert into Temp_country Select 'Iraq','Irak'
Insert into Temp_country Select 'Ireland','Irlanda'
Insert into Temp_country Select 'Israel','Israel'
Insert into Temp_country Select 'Italy','Italia'
Insert into Temp_country Select 'Jamaica','Jamaica'
Insert into Temp_country Select 'Japan','Japón'
Insert into Temp_country Select 'Jordan','Jordania'
Insert into Temp_country Select 'Kazakhstan','Kazajistán, Kazajstán'
Insert into Temp_country Select 'Kenya','Kenia'
Insert into Temp_country Select 'Kiribati','República de Kiribati'
Insert into Temp_country Select 'Korea, North','Corea del Norte'
Insert into Temp_country Select 'Korea, South','Corea del Sur'
Insert into Temp_country Select 'Kuwait','Kuwait'
Insert into Temp_country Select 'Kyrgyz Republic','Kirguzistán'
Insert into Temp_country Select 'Laos','Laos'
Insert into Temp_country Select 'Latvia','Letonia'
Insert into Temp_country Select 'Lebanon','Líbano'
Insert into Temp_country Select 'Lesotho','Lesoto'
Insert into Temp_country Select 'Liberia','Liberia'
Insert into Temp_country Select 'Libya','Libia'
Insert into Temp_country Select 'Liechtenstein','Principado de Liechtenstein'
Insert into Temp_country Select 'Lithuania','Lituania'
Insert into Temp_country Select 'Luxembourg','Luxemburgo'
Insert into Temp_country Select 'Macedonia','Macedonia'
Insert into Temp_country Select 'Madagascar','Madagascar'
Insert into Temp_country Select 'Malawi','Malaui'
Insert into Temp_country Select 'Malaysia','Malasia'
Insert into Temp_country Select 'Maldives','Maldivas'
Insert into Temp_country Select 'Mali','Mali'
Insert into Temp_country Select 'Malta','Malta'
Insert into Temp_country Select 'Marshall Islands','Islas Marshal'
Insert into Temp_country Select 'Mauritania','Mauritania'
Insert into Temp_country Select 'Mauritius','Mauricio'
Insert into Temp_country Select 'Mexico','México'
Insert into Temp_country Select 'Moldova','Moldavia'
Insert into Temp_country Select 'Monaco','Mónaco'
Insert into Temp_country Select 'Mongolia','Mongolia'
Insert into Temp_country Select 'Morocco','Marruecos'
Insert into Temp_country Select 'Mozambique','Mozambique'
Insert into Temp_country Select 'Myanmar (Burma)','Myanmar (Birmania)'
Insert into Temp_country Select 'Namibia','Namibia'
Insert into Temp_country Select 'Nauru','Nauru'
Insert into Temp_country Select 'Nepal','Nepal'
Insert into Temp_country Select 'Netherlands','Países Bajos'
Insert into Temp_country Select 'New Zealand','Nueva Zelanda'
Insert into Temp_country Select 'Nicaragua','Nicaragua'
Insert into Temp_country Select 'Niger','Níger'
Insert into Temp_country Select 'Nigeria','Nigeria'
Insert into Temp_country Select 'Norway','Noruega'
Insert into Temp_country Select 'Oman','Omán'
Insert into Temp_country Select 'Pakistan','Paquistán'
Insert into Temp_country Select 'Palau','Palaos'
Insert into Temp_country Select 'Panama','Panamá'
Insert into Temp_country Select 'Papua New Guinea','Papua-Nueva Guiné'
Insert into Temp_country Select 'Paraguay','Paraguay'
Insert into Temp_country Select 'Peru','Perú'
Insert into Temp_country Select 'Philippines','Filipinas'
Insert into Temp_country Select 'Poland','Polonia'
Insert into Temp_country Select 'Portugal','Portugal'
Insert into Temp_country Select 'Qatar','Catar'
Insert into Temp_country Select 'Romania','Rumanía'
Insert into Temp_country Select 'Russia','Rusia'
Insert into Temp_country Select 'Rwanda','Ruanda'
Insert into Temp_country Select 'Saint Kitts and Nevis','San Cristóbal y Nieves'
Insert into Temp_country Select 'Saint Lucia','Santa Lucía'
Insert into Temp_country Select 'Samoa','Samoa'
Insert into Temp_country Select 'San Marino','San Marino'
Insert into Temp_country Select 'Sao Tome and Principe','Santo Tomé y Príncipe'
Insert into Temp_country Select 'Saudi Arabia','Arabia Saudí'
Insert into Temp_country Select 'Senegal','Senegal'
Insert into Temp_country Select 'Serbia and Montenegro','Serbia y Montenegro'
Insert into Temp_country Select 'Seychelles','Seichelles'
Insert into Temp_country Select 'Sierra Leone','Sierra Leona'
Insert into Temp_country Select 'Singapore','Singapur'
Insert into Temp_country Select 'Slovakia','Eslovaquia'
Insert into Temp_country Select 'Slovenia','Eslovenia'
Insert into Temp_country Select 'Solomon Islands','Islas Salomón'
Insert into Temp_country Select 'Somalia','Somalia'
Insert into Temp_country Select 'South Africa','Sudáfrica'
Insert into Temp_country Select 'Spain','España'
Insert into Temp_country Select 'Sri Lanka','Sri Lanka'
Insert into Temp_country Select 'Sudan','Sudán'
Insert into Temp_country Select 'Suriname','Surinám'
Insert into Temp_country Select 'Swaziland','Suazilandia'
Insert into Temp_country Select 'Sweden','Suecia'
Insert into Temp_country Select 'Switzerland','Suiza'
Insert into Temp_country Select 'Syria','Siria'
Insert into Temp_country Select 'Taiwan','Taiwán'
Insert into Temp_country Select 'Tajikistan','Tayikistán'
Insert into Temp_country Select 'Tanzania','Tanzania'
Insert into Temp_country Select 'Thailand','Tailandia'
Insert into Temp_country Select 'The Bahamas','Las Bahamas'
Insert into Temp_country Select 'The Gambia','Gambia'
Insert into Temp_country Select 'Togo','Togo'
Insert into Temp_country Select 'Tonga','Tonga'
Insert into Temp_country Select 'Trinidad and Tobago','Trindad y Tobago'
Insert into Temp_country Select 'Tunisia','Túnez'
Insert into Temp_country Select 'Turkey','Turquía'
Insert into Temp_country Select 'Turkmenistan','Turkmenistán'
Insert into Temp_country Select 'Tuvalu','Tuvalu'
Insert into Temp_country Select 'Uganda','Uganda'
Insert into Temp_country Select 'Ukraine','Ucrania'
Insert into Temp_country Select 'United Arab Emirates','Emiratos Árabes Unidos'
Insert into Temp_country Select 'United Kingdom','Reino Unido'
Insert into Temp_country Select 'United States','Estados Unidos'
Insert into Temp_country Select 'Uruguay','Uruguay'
Insert into Temp_country Select 'Uzbekistan','Uzbequistán'
Insert into Temp_country Select 'Vanuatu','Vanuatu'
Insert into Temp_country Select 'Vatican City','Ciudad del Vaticano'
Insert into Temp_country Select 'Venezuela','Venezuela'
Insert into Temp_country Select 'Vietnam','Vietnam'
Insert into Temp_country Select 'Yemen','Yemen'
Insert into Temp_country Select 'Zambia','Zambia'
Insert into Temp_country Select 'Zimbabwe','Zimbabue'

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

delete from Country
insert into Country (CountryName,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,Nationality,NationalityID,CountryID,IsDefault,ISDCode,CountryCode,PhoneNo_Length)
select distinct D.chinesechar,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,Nationality,NationalityID,CountryID,IsDefault,ISDCode,CountryCode,PhoneNo_Length from Temp_country D
inner join Tempcountry tbl on tbl.CountryName =D.Name  --and OrgID =@OrgiD 

--------------------------------------------------------------------------------------------------
----------------------------------Investigation Method---------------------------------------------
Drop table TempInvestigationMethod
Create table TempInvestigationMethod(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempInvestigationMethod Select 'Agarose Gel Electrophoresis & Immunofixation','Electroforesis con gel de agarosa e Inmunofijación'
Insert into TempInvestigationMethod Select 'Agglutination','Aglutinación'
Insert into TempInvestigationMethod Select 'BCG','Bacilo de Calmette-Guerin (Bacilo de la Tuberculosis)'
Insert into TempInvestigationMethod Select 'Biuret','Biuret'
Insert into TempInvestigationMethod Select 'Calculated','Calculado'
Insert into TempInvestigationMethod Select 'Chromatographic Immunoassay','Inmunoensayo cromatográfico'
Insert into TempInvestigationMethod Select 'CLIA','Inmunoensayo de Quimioluminescencia'
Insert into TempInvestigationMethod Select 'CMIA','Inmunoensayo de Carbonylmetallo'
Insert into TempInvestigationMethod Select 'Colorimetric','Colorimétrica'
Insert into TempInvestigationMethod Select 'Diacetyl monoxime method','Método de diacetil monoxima'
Insert into TempInvestigationMethod Select 'Diazo','Diazocompuesto'
Insert into TempInvestigationMethod Select 'DPD','Dietil-p-fenilenodiamina'
Insert into TempInvestigationMethod Select 'Dye Reduction','Reducción de colorantes'
Insert into TempInvestigationMethod Select 'ECLIA','Electroensayo de Inmunoensayo de Quimioluminescencia'
Insert into TempInvestigationMethod Select 'EIA','Enzimoinmunoanálisis'
Insert into TempInvestigationMethod Select 'Electrical Impedance','Impedancia eléctrica'
Insert into TempInvestigationMethod Select 'Electrophoresis','Electroforesis'
Insert into TempInvestigationMethod Select 'ELFA','Análisis de Fluorescencia enzimática'
Insert into TempInvestigationMethod Select 'ELIA','Análisis de Fluorescencia enzimática'
Insert into TempInvestigationMethod Select 'ELISA','Análisis de inmunoabsorción enzimática'
Insert into TempInvestigationMethod Select 'Enzymatic','Enzimático'
Insert into TempInvestigationMethod Select 'Enzymatic Clearance(PEG)','Depuración enzimática (Polietilenglicol)'
Insert into TempInvestigationMethod Select 'Ferrozine','Ferrozina'
Insert into TempInvestigationMethod Select 'GOD-POD','Glucosa Oxidasa y Peroxidasa (GOD-POD)'
Insert into TempInvestigationMethod Select 'GPO-PAP','Glicerolfosfato Oxidasa y Peróxido de Aminofenazona (GPO-PAP)'
Insert into TempInvestigationMethod Select 'Hexokinase','Hexoquinasa'
Insert into TempInvestigationMethod Select 'HPLC','Cromatografía Líquida de Alta Resolución (HPLC)'
Insert into TempInvestigationMethod Select 'IFCC','Método del Comité de Enzimas de la Federación Internacional de Química Clínica (IFCC)'
Insert into TempInvestigationMethod Select 'IFCC without P5P','Método IFCC sin Piridoxal-5''-Fosfato'
Insert into TempInvestigationMethod Select 'IFCC/L -->P','Método IFCC por lipoproteína a (Lpa)'
Insert into TempInvestigationMethod Select 'Immunoassay','Inmunoensayo'
Insert into TempInvestigationMethod Select 'Immunochromatography','Inmunocromatografía'
Insert into TempInvestigationMethod Select 'Immunofiltration','Inmunofiltrado'
Insert into TempInvestigationMethod Select 'Immunofixation','Inmunofijación'
Insert into TempInvestigationMethod Select 'Immunofixation electrophoresis','Electroforesis con inmunofijación'
Insert into TempInvestigationMethod Select 'Immunoturbidometric Assay','Ensayo Inmunoturbidimétrico'
Insert into TempInvestigationMethod Select 'Impedance & Light Scattering','Impedancia y Distorsion de la luz'
Insert into TempInvestigationMethod Select 'ISE','Ion-selectivo'
Insert into TempInvestigationMethod Select 'Jaffe','Reacción de Jaffé'
Insert into TempInvestigationMethod Select 'Leishman Stain','Tinción de Leishman'
Insert into TempInvestigationMethod Select 'Methylene Blue Stain','Tinción de azul de metileno'
Insert into TempInvestigationMethod Select 'Molybdate UV','Método Espectrofotométrico del Molibdato de amonio'
Insert into TempInvestigationMethod Select 'Nephlometer','Nefelómetro'
Insert into TempInvestigationMethod Select 'o-CPC','o-Cresolftaleína'
Insert into TempInvestigationMethod Select 'Oxidising method','Método por Oxidación'
Insert into TempInvestigationMethod Select 'PETINIA','Inmunoensayos de Inhibición Turbidimétrico Mejorado por Partículas (PETINIA)'
Insert into TempInvestigationMethod Select 'Photometry','Fotometría'
Insert into TempInvestigationMethod Select 'Slide Agglutination','Aglutinación en Portaobjetos'
Insert into TempInvestigationMethod Select 'Thick & Thin Smears','Frotisgrueso y fino estándar'
Insert into TempInvestigationMethod Select 'Tube Agglutination','Aglutinación en tubo'
Insert into TempInvestigationMethod Select 'Turbidimetric','Turbidimetría'
Insert into TempInvestigationMethod Select 'Urease','Ureasa'
Insert into TempInvestigationMethod Select 'Uricase','Urato-oxidasa'
Insert into TempInvestigationMethod Select 'Westergren','Método de Westergren'

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into InvestigationMethod (MethodID,MethodName,OrgID ,LangCode )
select distinct D.MethodID,tbl.ChineseChar,@OrgiD ,@language from InvestigationMethod D
inner join TempInvestigationMethod tbl on tbl.Name =D.MethodName  and OrgID =@OrgiD 
where OrgID =@OrgiD 
----------------------------------------------------------------------------------------------------------
--------------------Cash Expense Master--------------------------------------------------------------------
Drop table TempCashExpenseMaster
Create table TempCashExpenseMaster(
	[HeadId] [bigint] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[HeadName] [nvarchar](50) NULL,
	[HeadDesc] [nchar](3) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[OrgID] [bigint] NOT NULL)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
Insert into TempCashExpenseMaster(HeadName,HeadDesc,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgID)
Select distinct HeadName,HeadDesc,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,OrgID from CashExpenseMaster where orgid=@OrgiD


Drop table Temp_CashExpenseMaster
Create table Temp_CashExpenseMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into Temp_CashExpenseMaster Select 'Food','Alimentos'
Insert into Temp_CashExpenseMaster Select 'Hospitality','Servicios hospitalarios'
Insert into Temp_CashExpenseMaster Select 'Others','Otros'
Insert into Temp_CashExpenseMaster Select 'Physician','Médico'
Insert into Temp_CashExpenseMaster Select 'Postage','Gastos de envío'
Insert into Temp_CashExpenseMaster Select 'Staff Welfare','Bienestar del personal'
Insert into Temp_CashExpenseMaster Select 'Suppliers','Proveedores'
Insert into Temp_CashExpenseMaster Select 'Travelling','Viaje'

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

delete from CashExpenseMaster where orgid=86
insert into CashExpenseMaster (HeadName ,HeadDesc ,OrgID)
select distinct D.ChineseChar ,HeadDesc ,OrgID from Temp_CashExpenseMaster D
inner join TempCashExpenseMaster tbl on tbl.HeadName  =D.Name  and OrgID =@OrgiD 
where  OrgID =@OrgiD 
----------------------------------------------------------------------------------------------------------------
------------------------Shipping Information--------------------------------------------------------------------
Drop table TempShippingConditionMaster
Create table TempShippingConditionMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempShippingConditionMaster Select 'Refrigerated-(2oC to 8oC)','Refrigerado -(2° a 8°C)'
Insert into TempShippingConditionMaster Select 'Frozen-(-20oC)','Congelado -(-20°C)'
Insert into TempShippingConditionMaster Select 'Temprature control Ambient-(15oC to 25oC )','Control de Temperatura Ambiente -(15°C a 25°C)'
Insert into TempShippingConditionMaster Select 'Ambient-(Room temprature)','Temperatura del Cuarto Ambiente'


declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into ShippingConditionMaster (ShippingConditionID,ConditionDesc,LangCode )
select distinct ShippingConditionID,tbl.chinesechar,@language from ShippingConditionMaster S
inner join TempShippingConditionMaster tbl on tbl.Name =S.ConditionDesc  


----------------------------------------------------------------------------------------------------------------------------------------
------------------------Search Columns--------------------------------------------------------------------------------------------------

Drop table TempSearchColumns
Create table TempSearchColumns(
	[SearchColumnID] [int],
	[SearchColumnName] [nvarchar](50) NULL)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
Insert into TempSearchColumns(SearchColumnID,SearchColumnName)
Select distinct SearchColumnID,SearchColumnName from searchcolumns 

select * from TempSearchColumns
Drop table Temp_SearchColumns
Create table Temp_SearchColumns(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))


Insert into Temp_SearchColumns Select 'Accession Number','Número de Ingreso'
Insert into Temp_SearchColumns Select 'Address','Dirección'
Insert into Temp_SearchColumns Select 'Age','Edad'
Insert into Temp_SearchColumns Select 'Contact No','Número de Contacto'
Insert into Temp_SearchColumns Select 'InvestigationList','Lista de investigación'
Insert into Temp_SearchColumns Select 'Investigationdetails','Detalles de investigación'
Insert into Temp_SearchColumns Select 'Location','Ubicación'
Insert into Temp_SearchColumns Select 'Patient Name','Nombre del Paciente'
Insert into Temp_SearchColumns Select 'Patient Number','Número del paciente'
Insert into Temp_SearchColumns Select 'PerformingPhysicain','Médico Practicante'
Insert into Temp_SearchColumns Select 'Physician Name','Nombre del Médico'
Insert into Temp_SearchColumns Select 'Ref Physician','Médico que remite'
Insert into Temp_SearchColumns Select 'Reporting Radiologist','Radiólogo que reporta'
Insert into Temp_SearchColumns Select 'Status','Estado'
Insert into Temp_SearchColumns Select 'URNO','Número de Referencia Única'
Insert into Temp_SearchColumns Select 'Visit Date','Fecha de Visita'
Insert into Temp_SearchColumns Select 'Visit Purpose','Propósito de la visita'
Insert into Temp_SearchColumns Select 'Visit Time','Hora de visita'
Insert into Temp_SearchColumns Select 'VisitID','Documento de identificación del visitante'
Insert into Temp_SearchColumns Select 'Visitnumber','Número de visita'
Insert into Temp_SearchColumns Select 'WardNo','Número de sala'

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

delete from SearchColumns
SET IDENTITY_INSERT SearchColumns ON
insert into SearchColumns (SearchColumnID ,SearchColumnName)
select D.SearchColumnID, tbl.chinesechar from TempSearchColumns D
inner join Temp_SearchColumns tbl on tbl.Name   =D.SearchColumnName    order by D.SearchColumnID asc
SET IDENTITY_INSERT SearchColumns OFF
-----------------------------------------------------------------------------------------------------------------
---------------------Search type master-----------------------------------------------------------------------
Drop table TempSearchTypeMaster
Create table TempSearchTypeMaster(
	[SearchTypeID] [int] NOT NULL,
	[SearchTypeName] [nvarchar](50) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
Insert into TempSearchTypeMaster(SearchTypeID,SearchTypeName,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt)
Select distinct SearchTypeID,SearchTypeName,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt from SearchTypeMaster 

Drop table Temp_SearchTypeMaster
Create table Temp_SearchTypeMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into Temp_SearchTypeMaster Select 'BillSearch','Búsqueda de Cuenta'
Insert into Temp_SearchTypeMaster Select 'HomeCollection','Recogida a domicilio'
Insert into Temp_SearchTypeMaster Select 'InPatientSearch','Búsqueda de Pacientes internos'
Insert into Temp_SearchTypeMaster Select 'IntendSearch','Búsqueda prevista'
Insert into Temp_SearchTypeMaster Select 'INVENTORY','INVENTARIO'
Insert into Temp_SearchTypeMaster Select 'InvestigationSearch','Búsqueda Investigativa'
Insert into Temp_SearchTypeMaster Select 'IP','Paciente interno'
Insert into Temp_SearchTypeMaster Select 'IPPayments','Pago de Paciente interno'
Insert into Temp_SearchTypeMaster Select 'IPSettlement','Acuerdo para Pacientes Internos'
Insert into Temp_SearchTypeMaster Select 'IPVisitSearch','Búsqueda de visitas para Pacientes Internos'
Insert into Temp_SearchTypeMaster Select 'Lab','Laboratorio'
Insert into Temp_SearchTypeMaster Select 'LabSummaryReport','Resumen del Informe de Laboratorio'
Insert into Temp_SearchTypeMaster Select 'ManageSchedules','Manejo de horarios'
Insert into Temp_SearchTypeMaster Select 'OP','Paciente externo'
Insert into Temp_SearchTypeMaster Select 'OutPatientSearch','Búsqueda de pacientes externos'
Insert into Temp_SearchTypeMaster Select 'PurchaseOrder','Orden de Compra'
Insert into Temp_SearchTypeMaster Select 'Quotation','Cotización'
Insert into Temp_SearchTypeMaster Select 'ReceiptSearch','Búsqueda de Recibo'
Insert into Temp_SearchTypeMaster Select 'Referral','Referido'
Insert into Temp_SearchTypeMaster Select 'SampleSearch','Búsqueda de Muestras'
Insert into Temp_SearchTypeMaster Select 'StockDamage','Daño de material'
Insert into Temp_SearchTypeMaster Select 'StockIssued','Material emitido'
Insert into Temp_SearchTypeMaster Select 'StockReceive','Recibo de Material'
Insert into Temp_SearchTypeMaster Select 'StockReturn','Devolución de Material'
Insert into Temp_SearchTypeMaster Select 'TodaysVisit','Visitas del día'
Insert into Temp_SearchTypeMaster Select 'TransferSample','Transferencia de muestras'
Insert into Temp_SearchTypeMaster Select 'VisitSearch','Búsqueda de visitas'

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

delete from SearchTypeMaster

insert into SearchTypeMaster (SearchTypeID,SearchTypeName)
select  D.SearchTypeID,tbl.chinesechar from TempSearchTypeMaster D
inner join Temp_SearchTypeMaster tbl on tbl.Name   =D.SearchTypeName    order by D.SearchTypeID asc

-------------------------------------------------------------------------------------------------------------
-------------------------Master Categories---------------------------------------------------------------------
select * from MasterCategories where orgid=86

Drop table MasterCategories
Create table TempMasterCategories(
	[CategoryId] [bigint],
	[CategoryName] [nvarchar](50) NULL,
	[OrgID] [int] NULL,
	[CategoryCode] [nvarchar](20) NULL)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
Insert into TempMasterCategories(CategoryId,CategoryName,OrgID,CategoryCode)
Select distinct CategoryId,CategoryName,OrgID,CategoryCode from MasterCategories where orgid=86

select * from TempMasterCategories order by CategoryName asc
Drop table Temp_MasterCategories
Create table Temp_MasterCategories(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into Temp_MasterCategories Select 'BillNumber','Número de Cuenta'
Insert into Temp_MasterCategories Select 'Client','Cliente'
Insert into Temp_MasterCategories Select 'InvoiceNumber','Número de Factura'
Insert into Temp_MasterCategories Select 'Patient Number','Número del Paciente'
Insert into Temp_MasterCategories Select 'Refund Number','Número de Devolución'
Insert into Temp_MasterCategories Select 'SampleIdentifier','Identificador de Muestras'
Insert into Temp_MasterCategories Select 'Token Number','Número de Seguridad'
Insert into Temp_MasterCategories Select 'VisitNumber','Número de Visita'
Insert into Temp_MasterCategories Select 'Voucher Number','Número de Comprobante'


declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

delete from MasterCategories where orgid=86

SET IDENTITY_INSERT MasterCategories ON
insert into MasterCategories (CategoryId,CategoryName,OrgID,CategoryCode)
select  D.CategoryId,tbl.ChineseChar ,86,D.CategoryCode from TempMasterCategories D
inner join Temp_MasterCategories tbl on tbl.Name   =D.CategoryName and orgid=86 where orgid=86  order by D.CategoryId asc

SET IDENTITY_INSERT MasterCategories OFF
-------------------------------------------------------------------------------------------------------------
---------------------------Delivery type master--------------------------------------------------------------

Drop table TempDeliveryTypeMaster
Create table TempDeliveryTypeMaster(
	[DeliveryTypeID] [bigint] ,
	[DeliveryTypeName] [nvarchar](255) NULL,
	[DeliveryType] [nvarchar](20) NULL,
	[OrgID] [int] NULL,
	[ModifiedAt] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
Insert into TempDeliveryTypeMaster(DeliveryTypeID,DeliveryTypeName,DeliveryType,OrgID,ModifiedAt,CreatedBy,CreatedAt,ModifiedBy)
Select distinct DeliveryTypeID,DeliveryTypeName,DeliveryType,OrgID,ModifiedAt,CreatedBy,CreatedAt,ModifiedBy from DeliveryTypeMaster


Drop table Temp_DeliveryTypeMaster
Create table Temp_DeliveryTypeMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))


Insert into Temp_DeliveryTypeMaster Select 'Assisted','Asistido'
Insert into Temp_DeliveryTypeMaster Select 'Assisted (High forceps)','Asistido (Con Fórceps Altos)'
Insert into Temp_DeliveryTypeMaster Select 'Assisted (Low forceps)','Asistido (Con Fórceps Bajos)'
Insert into Temp_DeliveryTypeMaster Select 'Assisted (Vacuum extraction)','Asistido (Extracción con Ventosa)'
Insert into Temp_DeliveryTypeMaster Select 'Induced','Inducido'
Insert into Temp_DeliveryTypeMaster Select 'LSCS','Cesárea Cervical Baja'
Insert into Temp_DeliveryTypeMaster Select 'Oxytocin-induced','Inducido por Oxitocina'
Insert into Temp_DeliveryTypeMaster Select 'Spontaneous','Espontáneo'
Insert into Temp_DeliveryTypeMaster Select 'Unassisted','Sin Asistencia'
Insert into Temp_DeliveryTypeMaster Select 'Vaginal','Vaginal'
Insert into Temp_DeliveryTypeMaster Select 'Vaginal delivery with episiotomy','Parto Vaginal con Epistotomía'
Insert into Temp_DeliveryTypeMaster Select 'Vaginal delivery without episiotomy','Parto Vaginal sin Epistotomía'


declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

select * from DeliveryTypeMaster
SET IDENTITY_INSERT DeliveryTypeMaster ON
insert into DeliveryTypeMaster (DeliveryTypeID,DeliveryTypeName,DeliveryType)
select D.DeliveryTypeID,tbl.chinesechar,D.DeliveryType from TempDeliveryTypeMaster D
inner join Temp_DeliveryTypeMaster tbl on tbl.Name   =D.DeliveryTypeName  order by D.DeliveryTypeID asc

SET IDENTITY_INSERT DeliveryTypeMaster OFF

--------------------------------------------------------------------------------------------------------
-------------------------DesignationMaster-----------------------------------------------------------------
select * from TempDesignationmaster where orgid=86

Drop table TempDesignationmaster
Create table TempDesignationmaster(
	[DesignationID] [bigint] NULL,
	[DesignationName] [nvarchar](255) NULL,
	[OrgID] [bigint] NULL,
	[DesignationText] [nvarchar](255) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
Insert into TempDesignationmaster(DesignationID,DesignationName,OrgID)
Select distinct DesignationID,DesignationName,OrgID from designationmaster where orgid=86


Drop table Temp_DesignationMaster
Create table Temp_DesignationMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into Temp_DesignationMaster Select 'ACCESSION OFFICER','OFICIAL DE INGRESOS'
Insert into Temp_DesignationMaster Select 'AREA SALES MANAGER','GERENTE DEL ÁREA DE VENTAS'
Insert into Temp_DesignationMaster Select 'ASSISTANT','ASISTENTE'
Insert into Temp_DesignationMaster Select 'ASSISTANT GENERAL MANAGER','DIRECTOR GENERAL ADJUNTO'
Insert into Temp_DesignationMaster Select 'ASSISTANT MANAGER','SUBDIRECTOR'
Insert into Temp_DesignationMaster Select 'ASSOCIATE TEAM LEAD','LÍDER DEL EQUIPO ASOCIADO'
Insert into Temp_DesignationMaster Select 'ASSOCIATE VICE PRESIDENT','VICEPRESIDENTE ASOCIADO'
Insert into Temp_DesignationMaster Select 'BIOMEDICAL ENGINEER','INGENIÉRO BIOMÉDICO'
Insert into Temp_DesignationMaster Select 'CENTER HEAD','JEFE DEL CENTRO'
Insert into Temp_DesignationMaster Select 'CHIEF MARKETING OFFICER','DIRECTOR OFICIAL DE MERCADEO'
Insert into Temp_DesignationMaster Select 'CLINICAL RESEARCH COORDIN','COORDINADOR DE INVESTIGACIÓN CLÍNICA'
Insert into Temp_DesignationMaster Select 'CLINICAL RESEARCH EXECUTIVE','EJECUTIVO DE INVESTIGACIÓN CLÍNICA'
Insert into Temp_DesignationMaster Select 'CLINICAL RESEARCH OFFICER','JEFE DE INVESTIGACIÓN CLÍNICA'
Insert into Temp_DesignationMaster Select 'CO-ORDINATOR HEALTH CHECK','COORDINADOR DE REVISIÓN MÉDICA'
Insert into Temp_DesignationMaster Select 'CUSTOMER CARE ADVISOR','ASESOR DE SERVICIO AL CLIENTE'
Insert into Temp_DesignationMaster Select 'Customer Care Executive','EJECUTIVO DE SERVICIO AL CLIENTE'
Insert into Temp_DesignationMaster Select 'DATA ENTRY OPERATOR','OPERADOR DE ENTRADA DE DATOS'
Insert into Temp_DesignationMaster Select 'DEPUTY GENERAL MANAGER','GERENTE GENERAL ADJUNTO'
Insert into Temp_DesignationMaster Select 'DEPUTY MANAGER','GERENTE ADJUNTO'
Insert into Temp_DesignationMaster Select 'DEPUTY MANAGER - IT','GERENTE ADJUNTO DE TECNOLOGÍA'
Insert into Temp_DesignationMaster Select 'Deputy Manager Accounts','GERENTE ADJUNTO DE CONTABILIDAD'
Insert into Temp_DesignationMaster Select 'Deputy Manager HR','GERENTE ADJUNTO DE RECURSOS HUMANOS'
Insert into Temp_DesignationMaster Select 'DEPUTY REGIONAL SALES MAN','COMERCIAL ADUNTO DE VENTAS REGIONALES'
Insert into Temp_DesignationMaster Select 'DEPUTY SECTION HEAD','JEFE ADUNTO DE SECCIÓN'
Insert into Temp_DesignationMaster Select 'EXECUTIVE','EJECUTIVO'
Insert into Temp_DesignationMaster Select 'EXECUTIVE-PROJECTS','EJECUTIVO DE PROYECTOS'
Insert into Temp_DesignationMaster Select 'EXECUTIVE-STORES','EJECUTIVO DE BODEGA'
Insert into Temp_DesignationMaster Select 'FRONT DESK EXECUTIVE','EJECUTIVO DE RECEPCIÓN'
Insert into Temp_DesignationMaster Select 'GENERAL MANAGER','GERENTE GENERAL'
Insert into Temp_DesignationMaster Select 'GENERAL MANAGER-CORPORATE','GERENTE GENERAL CORPORATIVO'
Insert into Temp_DesignationMaster Select 'HEALTHCARE EXECUTIVE','EJECUTIVO DE SERVICIOS DE SALUD'
Insert into Temp_DesignationMaster Select 'HISTOPATHOLOGIST','ANATOMOPATÓLOGO'
Insert into Temp_DesignationMaster Select 'HOME CARE EXECUTIVE','EXECUTIVO DE ATENCIÓN DOMICILIARIA'
Insert into Temp_DesignationMaster Select 'HOME CARE SUPERVISOR','SUPERVISOR DE ATENCIÓN DOMICILIARIA'
Insert into Temp_DesignationMaster Select 'INFRASTRUCTURE MANAGER','GERENTE DE INFRAESTRUCTURA'
Insert into Temp_DesignationMaster Select 'JUNIOR HISTOPATHOLOGIST','ANATOMOPATÓLOGO JUNIOR'
Insert into Temp_DesignationMaster Select 'JUNIOR PATHOLOGIST','PATÓLOGO JUNIOR'
Insert into Temp_DesignationMaster Select 'LAB ASSISTANT','ASISTENTE DE LABORATORIO'
Insert into Temp_DesignationMaster Select 'LEAD ACCESSION OFFICER','OFICIAL LÍDER DE INGRESOS'
Insert into Temp_DesignationMaster Select 'LEAD HEALTHCARE EXECUTIVE','LÍDER DE EJECUTIVO DE SERVICIOS DE LA SALUD'
Insert into Temp_DesignationMaster Select 'MANAGER','GERENTE'
Insert into Temp_DesignationMaster Select 'MANAGER-BUSINESS DEVELOPMENT','GERENTE DE DESARROLLO DE NEGOCIOS'
Insert into Temp_DesignationMaster Select 'MANAGER-PHLEBOTOMY SERVICE','GERENTE DE SERVICIOS DE FLEBOTOMÍA'
Insert into Temp_DesignationMaster Select 'MANAGER-TECHNICAL SALES','GERENTE DE VENTAS TÉCNICAS'
Insert into Temp_DesignationMaster Select 'MICROBIOLOGIST','MICROBIÓLOGO'
Insert into Temp_DesignationMaster Select 'NETWORK OFFICER','OFICIAL DE REDES'
Insert into Temp_DesignationMaster Select 'OFFICER','OFICIAL'
Insert into Temp_DesignationMaster Select 'OPERATION HEAD','JEFE DE OPERACIÓN'
Insert into Temp_DesignationMaster Select 'PANTRY ASSISTANT','ASISTENTE DE ALMACÉN'
Insert into Temp_DesignationMaster Select 'PATHOLOGIST','PATÓLOGO'
Insert into Temp_DesignationMaster Select 'PHLEBETOMIST','FLEBOTOMISTA'
Insert into Temp_DesignationMaster Select 'QUALITY ASSURANCE AUDITOR','AUDITOR DE CONTROL DE CALIDAD'
Insert into Temp_DesignationMaster Select 'QUALITY EXECUTIVE','EJECUTIVO DE CALIDAD'
Insert into Temp_DesignationMaster Select 'REPORTS OFFICER','OFICIAL DE INFORMES'
Insert into Temp_DesignationMaster Select 'SALES EXECUTIVE','EJECUTIVO DE VENTAS'
Insert into Temp_DesignationMaster Select 'SCIENTIFIC OFFICER','GESTOR CIENTÍFICO'
Insert into Temp_DesignationMaster Select 'SECTION HEAD','JEFE DE SECCIÓN'
Insert into Temp_DesignationMaster Select 'SENIOR ACCESSION OFFICER','OFICIAL DE INGRESOS PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR CLINICAL RESEARCH','INVESTIGADOR CLÍNICO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR EXECUTIVE','EJECUTIVO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR EXECUTIVE-BUSINESS','XEJECUTIVO DE NEGOCIOS PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR HEALTHCARE EXECUTIVE','EJECUTIVO DE SERVICIOS DE LA SALUD PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR LABORATORY MANAGER','GERENTE DE LABORATORIO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR MANAGER','GERENTE PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR OFFICER','FUNCIONARIO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'STORE MANAGER','GERENTE DE BODEGA'
Insert into Temp_DesignationMaster Select 'STORE OFFICER','OFICIAL DE BODEGA'
Insert into Temp_DesignationMaster Select 'TEAM LEADER','LÍDER DE EQUIPO'
Insert into Temp_DesignationMaster Select 'TECHNICAL SALES OFFICER','OFICIAL DE VENTAS TÉCNICAS'
Insert into Temp_DesignationMaster Select 'TECHNICIAN','TÉCNICO'
Insert into Temp_DesignationMaster Select 'TECHNICIAN CUM PHLEBOTOMIST','FLEBOTOMISTA TÉCNICO TITULADO'
Insert into Temp_DesignationMaster Select 'TRAINEE LOGISTICS ASSOCIATION','ASOCIACIÓN DE ENTRENAMIENTO LOGÍSTICO'
Insert into Temp_DesignationMaster Select 'TRAINING COORDINATOR','COORDINADOR DE ENTRENAMIENTO'
Insert into Temp_DesignationMaster Select 'VICE PRESIDENT','VICEPRESIDENTE'
Insert into Temp_DesignationMaster Select 'ZONAL SALES MANAGER','GERENTE DE VENTAS REGIONAL'

delete from DesignationMaster where orgid=86
declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'


SET IDENTITY_INSERT DesignationMaster ON
insert into DesignationMaster (DesignationID,DesignationName,OrgID)
select D.DesignationID,tbl.ChineseChar ,D.OrgID from TempDesignationmaster D
inner join Temp_DesignationMaster tbl on tbl.Name   =D.DesignationName and orgid=@orgid where orgid=@OrgiD   order by D.DesignationID asc
SET IDENTITY_INSERT DesignationMaster OFF
-------------------------------------------------------------------------------------------------------------------------------------------

select * from reasonmaster
select * from InvReasonOrgMapping where orgid=86


select * from TempDesignationmaster where orgid=86

Drop table TempReasonMaster
Create table TempReasonMaster(
	[ReasonID] [bigint] null,
	[ReasonTypeID] [int] NULL,
	[Reason] [nvarchar](50) NULL,
	[ReasonCode] [nvarchar](5) NULL,
	[Status] [nchar](1) NULL,
	[CreatedBy] [bigint] NULL,
	[CreatedAt] [datetime] NULL,
	[ModifiedBy] [bigint] NULL,
	[ModifiedAt] [datetime] NULL,
	[SequenceNo] [int] NULL,
	[OrgID] [int] NULL,
	[LangCode] [nvarchar](20) NULL)

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'
Insert into TempReasonMaster(ReasonID,ReasonTypeID,Reason,ReasonCode,Status,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,SequenceNo,OrgID,LangCode)
Select distinct ReasonID,ReasonTypeID,Reason,ReasonCode,Status,CreatedBy,CreatedAt,ModifiedBy,ModifiedAt,SequenceNo,OrgID,LangCode from reasonmaster


Drop table Temp_DesignationMaster
Create table Temp_DesignationMaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into Temp_DesignationMaster Select 'ACCESSION OFFICER','OFICIAL DE INGRESOS'
Insert into Temp_DesignationMaster Select 'AREA SALES MANAGER','GERENTE DEL ÁREA DE VENTAS'
Insert into Temp_DesignationMaster Select 'ASSISTANT','ASISTENTE'
Insert into Temp_DesignationMaster Select 'ASSISTANT GENERAL MANAGER','DIRECTOR GENERAL ADJUNTO'
Insert into Temp_DesignationMaster Select 'ASSISTANT MANAGER','SUBDIRECTOR'
Insert into Temp_DesignationMaster Select 'ASSOCIATE TEAM LEAD','LÍDER DEL EQUIPO ASOCIADO'
Insert into Temp_DesignationMaster Select 'ASSOCIATE VICE PRESIDENT','VICEPRESIDENTE ASOCIADO'
Insert into Temp_DesignationMaster Select 'BIOMEDICAL ENGINEER','INGENIÉRO BIOMÉDICO'
Insert into Temp_DesignationMaster Select 'CENTER HEAD','JEFE DEL CENTRO'
Insert into Temp_DesignationMaster Select 'CHIEF MARKETING OFFICER','DIRECTOR OFICIAL DE MERCADEO'
Insert into Temp_DesignationMaster Select 'CLINICAL RESEARCH COORDIN','COORDINADOR DE INVESTIGACIÓN CLÍNICA'
Insert into Temp_DesignationMaster Select 'CLINICAL RESEARCH EXECUTIVE','EJECUTIVO DE INVESTIGACIÓN CLÍNICA'
Insert into Temp_DesignationMaster Select 'CLINICAL RESEARCH OFFICER','JEFE DE INVESTIGACIÓN CLÍNICA'
Insert into Temp_DesignationMaster Select 'CO-ORDINATOR HEALTH CHECK','COORDINADOR DE REVISIÓN MÉDICA'
Insert into Temp_DesignationMaster Select 'CUSTOMER CARE ADVISOR','ASESOR DE SERVICIO AL CLIENTE'
Insert into Temp_DesignationMaster Select 'Customer Care Executive','EJECUTIVO DE SERVICIO AL CLIENTE'
Insert into Temp_DesignationMaster Select 'DATA ENTRY OPERATOR','OPERADOR DE ENTRADA DE DATOS'
Insert into Temp_DesignationMaster Select 'DEPUTY GENERAL MANAGER','GERENTE GENERAL ADJUNTO'
Insert into Temp_DesignationMaster Select 'DEPUTY MANAGER','GERENTE ADJUNTO'
Insert into Temp_DesignationMaster Select 'DEPUTY MANAGER - IT','GERENTE ADJUNTO DE TECNOLOGÍA'
Insert into Temp_DesignationMaster Select 'Deputy Manager Accounts','GERENTE ADJUNTO DE CONTABILIDAD'
Insert into Temp_DesignationMaster Select 'Deputy Manager HR','GERENTE ADJUNTO DE RECURSOS HUMANOS'
Insert into Temp_DesignationMaster Select 'DEPUTY REGIONAL SALES MAN','COMERCIAL ADUNTO DE VENTAS REGIONALES'
Insert into Temp_DesignationMaster Select 'DEPUTY SECTION HEAD','JEFE ADUNTO DE SECCIÓN'
Insert into Temp_DesignationMaster Select 'EXECUTIVE','EJECUTIVO'
Insert into Temp_DesignationMaster Select 'EXECUTIVE-PROJECTS','EJECUTIVO DE PROYECTOS'
Insert into Temp_DesignationMaster Select 'EXECUTIVE-STORES','EJECUTIVO DE BODEGA'
Insert into Temp_DesignationMaster Select 'FRONT DESK EXECUTIVE','EJECUTIVO DE RECEPCIÓN'
Insert into Temp_DesignationMaster Select 'GENERAL MANAGER','GERENTE GENERAL'
Insert into Temp_DesignationMaster Select 'GENERAL MANAGER-CORPORATE','GERENTE GENERAL CORPORATIVO'
Insert into Temp_DesignationMaster Select 'HEALTHCARE EXECUTIVE','EJECUTIVO DE SERVICIOS DE SALUD'
Insert into Temp_DesignationMaster Select 'HISTOPATHOLOGIST','ANATOMOPATÓLOGO'
Insert into Temp_DesignationMaster Select 'HOME CARE EXECUTIVE','EXECUTIVO DE ATENCIÓN DOMICILIARIA'
Insert into Temp_DesignationMaster Select 'HOME CARE SUPERVISOR','SUPERVISOR DE ATENCIÓN DOMICILIARIA'
Insert into Temp_DesignationMaster Select 'INFRASTRUCTURE MANAGER','GERENTE DE INFRAESTRUCTURA'
Insert into Temp_DesignationMaster Select 'JUNIOR HISTOPATHOLOGIST','ANATOMOPATÓLOGO JUNIOR'
Insert into Temp_DesignationMaster Select 'JUNIOR PATHOLOGIST','PATÓLOGO JUNIOR'
Insert into Temp_DesignationMaster Select 'LAB ASSISTANT','ASISTENTE DE LABORATORIO'
Insert into Temp_DesignationMaster Select 'LEAD ACCESSION OFFICER','OFICIAL LÍDER DE INGRESOS'
Insert into Temp_DesignationMaster Select 'LEAD HEALTHCARE EXECUTIVE','LÍDER DE EJECUTIVO DE SERVICIOS DE LA SALUD'
Insert into Temp_DesignationMaster Select 'MANAGER','GERENTE'
Insert into Temp_DesignationMaster Select 'MANAGER-BUSINESS DEVELOPMENT','GERENTE DE DESARROLLO DE NEGOCIOS'
Insert into Temp_DesignationMaster Select 'MANAGER-PHLEBOTOMY SERVICE','GERENTE DE SERVICIOS DE FLEBOTOMÍA'
Insert into Temp_DesignationMaster Select 'MANAGER-TECHNICAL SALES','GERENTE DE VENTAS TÉCNICAS'
Insert into Temp_DesignationMaster Select 'MICROBIOLOGIST','MICROBIÓLOGO'
Insert into Temp_DesignationMaster Select 'NETWORK OFFICER','OFICIAL DE REDES'
Insert into Temp_DesignationMaster Select 'OFFICER','OFICIAL'
Insert into Temp_DesignationMaster Select 'OPERATION HEAD','JEFE DE OPERACIÓN'
Insert into Temp_DesignationMaster Select 'PANTRY ASSISTANT','ASISTENTE DE ALMACÉN'
Insert into Temp_DesignationMaster Select 'PATHOLOGIST','PATÓLOGO'
Insert into Temp_DesignationMaster Select 'PHLEBETOMIST','FLEBOTOMISTA'
Insert into Temp_DesignationMaster Select 'QUALITY ASSURANCE AUDITOR','AUDITOR DE CONTROL DE CALIDAD'
Insert into Temp_DesignationMaster Select 'QUALITY EXECUTIVE','EJECUTIVO DE CALIDAD'
Insert into Temp_DesignationMaster Select 'REPORTS OFFICER','OFICIAL DE INFORMES'
Insert into Temp_DesignationMaster Select 'SALES EXECUTIVE','EJECUTIVO DE VENTAS'
Insert into Temp_DesignationMaster Select 'SCIENTIFIC OFFICER','GESTOR CIENTÍFICO'
Insert into Temp_DesignationMaster Select 'SECTION HEAD','JEFE DE SECCIÓN'
Insert into Temp_DesignationMaster Select 'SENIOR ACCESSION OFFICER','OFICIAL DE INGRESOS PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR CLINICAL RESEARCH','INVESTIGADOR CLÍNICO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR EXECUTIVE','EJECUTIVO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR EXECUTIVE-BUSINESS','XEJECUTIVO DE NEGOCIOS PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR HEALTHCARE EXECUTIVE','EJECUTIVO DE SERVICIOS DE LA SALUD PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR LABORATORY MANAGER','GERENTE DE LABORATORIO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR MANAGER','GERENTE PRINCIPAL'
Insert into Temp_DesignationMaster Select 'SENIOR OFFICER','FUNCIONARIO PRINCIPAL'
Insert into Temp_DesignationMaster Select 'STORE MANAGER','GERENTE DE BODEGA'
Insert into Temp_DesignationMaster Select 'STORE OFFICER','OFICIAL DE BODEGA'
Insert into Temp_DesignationMaster Select 'TEAM LEADER','LÍDER DE EQUIPO'
Insert into Temp_DesignationMaster Select 'TECHNICAL SALES OFFICER','OFICIAL DE VENTAS TÉCNICAS'
Insert into Temp_DesignationMaster Select 'TECHNICIAN','TÉCNICO'
Insert into Temp_DesignationMaster Select 'TECHNICIAN CUM PHLEBOTOMIST','FLEBOTOMISTA TÉCNICO TITULADO'
Insert into Temp_DesignationMaster Select 'TRAINEE LOGISTICS ASSOCIATION','ASOCIACIÓN DE ENTRENAMIENTO LOGÍSTICO'
Insert into Temp_DesignationMaster Select 'TRAINING COORDINATOR','COORDINADOR DE ENTRENAMIENTO'
Insert into Temp_DesignationMaster Select 'VICE PRESIDENT','VICEPRESIDENTE'
Insert into Temp_DesignationMaster Select 'ZONAL SALES MANAGER','GERENTE DE VENTAS REGIONAL'

delete from DesignationMaster where orgid=86
declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'


SET IDENTITY_INSERT DesignationMaster ON
insert into DesignationMaster (DesignationID,DesignationName,OrgID)
select D.DesignationID,tbl.ChineseChar ,D.OrgID from TempDesignationmaster D
inner join Temp_DesignationMaster tbl on tbl.Name   =D.DesignationName and orgid=@orgid where orgid=@OrgiD   order by D.DesignationID asc
SET IDENTITY_INSERT DesignationMaster OFF
-------------------------------------------------------------------------------------------------------------------------------------------------
------------------Payment Type-------------------------------------------------------------------------------------------------------------------

Drop table TempPaymentType
Create table TempPaymentType(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempPaymentType Select 'Cash','Efectivo'
Insert into TempPaymentType Select 'Cheque','Cheque'
Insert into TempPaymentType Select 'Credit/Debit Card','Tarjeta crédito/débito'
Insert into TempPaymentType Select 'Demand Draft','Letra de cambio a la vista'
Insert into TempPaymentType Select 'VISA','VISA'
Insert into TempPaymentType Select 'MASTER','MASTER'
Insert into TempPaymentType Select 'AMEX','AMEX'
Insert into TempPaymentType Select 'Coupon','Cupón'
Insert into TempPaymentType Select 'Credit Note','Nota de crédito'


declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into PaymentType (PaymentTypeID,PaymentName,LanguageCode)
select distinct p.PaymentTypeID,tbl.chinesechar,@language from PaymentType P
inner join TempPaymentType tbl on tbl.Name =p.PaymentName  
------------------------------------------------------------------------------------------------------------------------------
-------------Investigation Header---------------------------------------------------------------------------------------------
Drop table TempInvestigationHeader
Create table TempInvestigationHeader(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempInvestigationHeader Select 'Adrenal Studies','Estudios adrenales'
Insert into TempInvestigationHeader Select 'Allergy Studies','Estudios de alergias'
Insert into TempInvestigationHeader Select 'Arterial Blood Gases','Gas en sangre arterial'
Insert into TempInvestigationHeader Select 'Bacteriology','Bacteriología'
Insert into TempInvestigationHeader Select 'BIOCHEMISTRY','BIOQUIMICA'
Insert into TempInvestigationHeader Select 'Cardiac Markers','Marcadores cardíacos'
Insert into TempInvestigationHeader Select 'CLINICAL CHEMISTRY','QUIMICA CLINICA'
Insert into TempInvestigationHeader Select 'CLINICAL PATHOLOGY','PATOLOGIA CLINICA'
Insert into TempInvestigationHeader Select 'Coagulation Studies','Pruebas de coagulación'
Insert into TempInvestigationHeader Select 'Complete Blood Count','Biometría hemática completa'
Insert into TempInvestigationHeader Select 'Cytology','Citología'
Insert into TempInvestigationHeader Select 'Diabetic Studies','Pruebas de diabetes'
Insert into TempInvestigationHeader Select 'Endocrynology','Endocrinología'
Insert into TempInvestigationHeader Select 'Fluid Cytology','Citología fluidos'
Insert into TempInvestigationHeader Select 'FNAC','Biopsia con punción por aspiración con aguja fina'
Insert into TempInvestigationHeader Select 'Haemoglobin Studies','Pruebas hemoglobina'
Insert into TempInvestigationHeader Select 'Hematology','Hematología'
Insert into TempInvestigationHeader Select 'Histo Pathology','Histopatología'
Insert into TempInvestigationHeader Select 'Hormonal Studies','Pruebas hormonales'
Insert into TempInvestigationHeader Select 'Immnunology Studies','Pruebas de inmunología'
Insert into TempInvestigationHeader Select 'IMMUNOASSAY','INMUNOENSAYO'
Insert into TempInvestigationHeader Select 'Infectious Disease','Enfermedad infecciosa'
Insert into TempInvestigationHeader Select 'Iron Studies','Pruebas de hierro'
Insert into TempInvestigationHeader Select 'Lipid Studies','Pruebas de lípidos'
Insert into TempInvestigationHeader Select 'Liver Function','Prueba hepática'
Insert into TempInvestigationHeader Select 'Male Reproductive Studies','Pruebas de reproducción masculina'
Insert into TempInvestigationHeader Select 'Metabolic Studies','Estudios de metabolismo'
Insert into TempInvestigationHeader Select 'MICROBIOLOGY','MICROBIOLOGIA'
Insert into TempInvestigationHeader Select 'Mineral Studies','Examen de minerales'
Insert into TempInvestigationHeader Select 'Protein Studies','Examen de proteínas'
Insert into TempInvestigationHeader Select 'Renal Studies','Examen renal'
Insert into TempInvestigationHeader Select 'Reprouctive Studies','Pruebas reproductivas'
Insert into TempInvestigationHeader Select 'Rheumatid Studies','Pruebas reumáticas'
Insert into TempInvestigationHeader Select 'Semen Analysis','Análisis del semen'
Insert into TempInvestigationHeader Select 'SEROLOGY','SEROLOGIA'
Insert into TempInvestigationHeader Select 'Stool Analysis','Análisis de heces'
Insert into TempInvestigationHeader Select 'Toxicology','Toxicología'
Insert into TempInvestigationHeader Select 'Transfusion Serology','Transfusión Serologia'
Insert into TempInvestigationHeader Select 'Tumor Marker','Marcador de tumor'
Insert into TempInvestigationHeader Select 'Urinalysis','Análisis de orina'
Insert into TempInvestigationHeader Select 'Urine Metobolism Studies','Pruebas de metabolismo de orina'
Insert into TempInvestigationHeader Select 'Veteniary Studies','Pruebas veterinarias'
Insert into TempInvestigationHeader Select 'VItamin Studies','Examen de vitaminas'

declare @OrgiD as int  = 86 
declare @language nvarchar(20) = 'es-ES'

insert into InvestigationHeader (HeaderID ,HeaderName ,IsActive ,LangCode)
select distinct p.HeaderID ,tbl.ChineseChar  ,IsActive ,@language from InvestigationHeader P
inner join TempInvestigationHeader tbl on tbl.Name =p.HeaderName  and langcode='en-GB'
-----------------------------------------------------------------------------------------------------------------------------
--------------InvReasonOrgMapping--------------------------------------------------------------------------------------------
drop table TempInvReasonOrgMapping
Create table TempInvReasonOrgMapping(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempInvReasonOrgMapping Select'Management Approval','Aprobación de gestión'
Insert into TempInvReasonOrgMapping Select'Marketing Camps','Campos de marketing'
Insert into TempInvReasonOrgMapping Select'Marketing Special Events','Eventos especiales de marketing'
Insert into TempInvReasonOrgMapping Select'Doctor recommendation','Recomendación médica'
Insert into TempInvReasonOrgMapping Select'Public Relations','Relaciones públicas'
Insert into TempInvReasonOrgMapping Select'Doctor Self and Immediate family','Doctor personal y para familia cercana'
Insert into TempInvReasonOrgMapping Select'Social Responsibility','Responsabilidad social'
Insert into TempInvReasonOrgMapping Select'Employee close Relative','Familiar cercano del empleado'
Insert into TempInvReasonOrgMapping Select'Ex-employee','Ex-empleado'
Insert into TempInvReasonOrgMapping Select'PANACEA DISCOUNT','DESCUENTO PANACEA'
Insert into TempInvReasonOrgMapping Select'Senior Management Approval','Aprobación de gestión de experto'
Insert into TempInvReasonOrgMapping Select'Government Official','Funcionario de gobierno'
Insert into TempInvReasonOrgMapping Select'QC - QUALITY CONTROL','CC- CONTROL DE CALIDAD'
Insert into TempInvReasonOrgMapping Select'Rate Correction Discounts','Descuentos tasa de corrección'
Insert into TempInvReasonOrgMapping Select'Recheck Sample','Comprobar de nuevo la muestra'
Insert into TempInvReasonOrgMapping Select'REGISTRATION ERRORS','ERRORES DE REGISTRO'
Insert into TempInvReasonOrgMapping Select'Repeat Sample','Repetir muestra'
Insert into TempInvReasonOrgMapping Select'SAMPLE NOT RECEIVED','MUESTRA NO RECIBIDA'
Insert into TempInvReasonOrgMapping Select'Unable to process','No es posible procesar'
Insert into TempInvReasonOrgMapping Select'Sample Quality Inappropriate','Calidad de muestra inadecuada'
Insert into TempInvReasonOrgMapping Select'Microclot Seen','Microcoagulación Observada'
Insert into TempInvReasonOrgMapping Select'Different Time Schedule','Calendario diferente'
Insert into TempInvReasonOrgMapping Select'Patient Delay','Retraso paciente'
Insert into TempInvReasonOrgMapping Select'Test Request on Hold','Prueba solicitada pendiente'
Insert into TempInvReasonOrgMapping Select'Patient in Sick','Paciente enfermo'
Insert into TempInvReasonOrgMapping Select'Patient Not Available','Paciente no disponible'
Insert into TempInvReasonOrgMapping Select'Inappropriate Container','envase inadecuado'
Insert into TempInvReasonOrgMapping Select'Inappropriate Patient Preparation','Preparación inadecuada del paciente'
Insert into TempInvReasonOrgMapping Select'Test Cancelled','Prueba cancelada'
Insert into TempInvReasonOrgMapping Select'Non-Cooperative Patient','Paciente no colaborador'
Insert into TempInvReasonOrgMapping Select'Missing Patient','Paciente ausente'
Insert into TempInvReasonOrgMapping Select'Corporate Alliances','Alianzas corporativas'
Insert into TempInvReasonOrgMapping Select'Doctors Relative','Familia doctor'
Insert into TempInvReasonOrgMapping Select'Doctors Self','Propio doctor'
Insert into TempInvReasonOrgMapping Select'Employee reference','Referencia empleado'
Insert into TempInvReasonOrgMapping Select'Govt Officials','Funcionarios de gobierno'
Insert into TempInvReasonOrgMapping Select'Doctors Prescription : Special Request from Doctor','Prescripciones médicas: Petición especial del médico'
Insert into TempInvReasonOrgMapping Select'Doctors Prescription : mentioning Maximum Discount','Prescripciones médicas: Mencionar Descuento máximo.'
Insert into TempInvReasonOrgMapping Select'Referance correction','Corrección referencia'
Insert into TempInvReasonOrgMapping Select'Medical Correlation','Correlación médica'
Insert into TempInvReasonOrgMapping Select'Clotted sample','Muestra coagulada'
Insert into TempInvReasonOrgMapping Select'Sample not received (S.N.R)','Muestra no recibida (M.N.R)'
Insert into TempInvReasonOrgMapping Select'Wrong sample','Muestra incorrecta'
Insert into TempInvReasonOrgMapping Select'Haemolysed sample','Muestra hemolizada'
Insert into TempInvReasonOrgMapping Select'Spot urine instead of 24hrs urine','Orina única en vez de orina de 24 horas'
Insert into TempInvReasonOrgMapping Select'Patient name mismatch on sample & on TRF','Nombre del paciente no coincide en la muestra y el formulario resultados de la prueba'
Insert into TempInvReasonOrgMapping Select'Patient''s name not mentioned on sample tube','Nombre del paciente no mencionado en el tubo de la muestra'
Insert into TempInvReasonOrgMapping Select'Histo sample received in Saline','Histo muestra recibida en solucion salina'
Insert into TempInvReasonOrgMapping Select'Dry swab received for AFB or anaerobic culture','Tampón seco recibido para BAAR o cultivo anaerobio'
Insert into TempInvReasonOrgMapping Select'Inactivate test code due to discontinue','Código de la prueba inactivo por discontinuidad'
Insert into TempInvReasonOrgMapping Select'Wrong Registration','Registro incorrecto'
Insert into TempInvReasonOrgMapping Select'Kit Not Available','Kit no disponible'
Insert into TempInvReasonOrgMapping Select'Test Deactivated','Prueba desactivada'
Insert into TempInvReasonOrgMapping Select'24hrs urine volume not mentioned','Volumen de orina 24 horas no mencionado'
Insert into TempInvReasonOrgMapping Select'Fluid/ separated plasma type not mentioned','Tipo de fluido/plasma separado no mencionado'
Insert into TempInvReasonOrgMapping Select'Ht & wt not given for Creatinine Clearance test','Altura y peso no proporcionados para la prueba de aclaramiento de creatinina'
Insert into TempInvReasonOrgMapping Select'Stone type not mentioned','Tipo de piedra no mencionado'
Insert into TempInvReasonOrgMapping Select'Cyclosporine level not mentioned','Nivel de ciclosporina'
Insert into TempInvReasonOrgMapping Select'Triple history not given (USG report)','Historial triple no proporcionada (informe de ecografía)'
Insert into TempInvReasonOrgMapping Select'Test name test code mismatch','El nombre de la prueba y el código de la prueba no coinciden'
Insert into TempInvReasonOrgMapping Select'History incomplete for Histopathology','Historial incompleto para Histopatología'
Insert into TempInvReasonOrgMapping Select'Request received through mail hold till time conf.','Petición recibida por correo reservado hasta tiempo conf.'
Insert into TempInvReasonOrgMapping Select'Age not given for GFR','Edad no proporcionada para GFR'
Insert into TempInvReasonOrgMapping Select'Wrong lab taken','Pruebas de lab tomadas incorrectas'
Insert into TempInvReasonOrgMapping Select'Wrong test selected','Prueba seleccionada incorrecta'
Insert into TempInvReasonOrgMapping Select'Test want to be cancelled before processing','Se quiere cancelar la prueba antes de procesar'
Insert into TempInvReasonOrgMapping Select'QNS or SNR & test want to cancelled & should','Se quieren y deberian cancelar la prueba por Cantidad no Suficiente y SNR'
Insert into TempInvReasonOrgMapping Select'Q.N.S','Cantidad no Suficiente'
Insert into TempInvReasonOrgMapping Select'Test Result For Sample having Error from Machine','Resultado de prueba para muestra con error de aparato'
Insert into TempInvReasonOrgMapping Select'Q.N.S For Recheck','Cantidad no Suficiente para confirmar de nuevo'
Insert into TempInvReasonOrgMapping Select'Sample Integrity Questionable/Contaminated','Integridad de la muestra dudosa/contaminada'
Insert into TempInvReasonOrgMapping Select'Lipemic Sample','Muestra con lipémicos'
Insert into TempInvReasonOrgMapping Select'Icteric Sample','Muestra con ictéricos'
Insert into TempInvReasonOrgMapping Select'Cells Degenerated','Células degeneradas'
Insert into TempInvReasonOrgMapping Select'Frozen Sample - Thawed','Muestra congelada - descongelada'
Insert into TempInvReasonOrgMapping Select'Duplicate Registration','Registro duplicado'
Insert into TempInvReasonOrgMapping Select'New Sample Requested','Nueva muestra solicitada'

declare @language nvarchar(20) = 'es-ES'
Declare @OrgID bigint=86

insert into InvReasonOrgMapping(StatusID,ReasonID,ORgID,Displaytext,LangCode)
select distinct IRM.StatusID,IRM.ReasonID,IRM.OrgID,tbl.ChineseChar ,@language from InvReasonOrgMapping IRM
inner join TempInvReasonOrgMapping tbl on tbl.Name =IRM.Displaytext -- and orgid=@OrgID 
where OrgID =@OrgID  --and LangCode ='en-GB'


----------------------------------------------------------------------------------------------------------------------------------------
--------------InvReasonOrgMapping--------------------------------------------------------------------------------------------
drop table TempReasonmaster
Create table TempReasonmaster(Sno int identity (1,1), Name Varchar(1000),ChineseChar  Nvarchar(1000))

Insert into TempReasonMaster Select'24 hrs urine volume not mentioned','Volúmen de orina de 24 horas no mencionado'
Insert into TempReasonMaster Select'Age not given for Glomerular Filtration Rate (GFR)','Edad no entregada para la Tasa de Filtración Glomerular (TFG).'
Insert into TempReasonMaster Select'Cells Degenerated','Células Degeneradas'
Insert into TempReasonMaster Select'ClientMaster Updation','Actualización Cliente Principal'
Insert into TempReasonMaster Select'Client Rate master Updation','Actualización tarifa del Cliente Principal'
Insert into TempReasonMaster Select'CLINICAL TRIALS - DISCOUNTS','Descuentos - Estudios Clínicos'
Insert into TempReasonMaster Select'Clotted sample','Muestra de Sangre'
Insert into TempReasonMaster Select'Completely leak out the sample','Completa filración de la muestra'
Insert into TempReasonMaster Select'Corporate Alliances','Alianzas Corporativas'
Insert into TempReasonMaster Select'Cyclosporine level not mentioned','Nivel de ciclosporina no mencionado'
Insert into TempReasonMaster Select'Different Time Schedule','Horario Diferente'
Insert into TempReasonMaster Select'Discount Coupon','Cupón de Descuento'
Insert into TempReasonMaster Select'Discrepancy between test code and test name','Discrepancia entre el código y nombre de la prueba'
Insert into TempReasonMaster Select'Doctor recommendation','Recomendaciones del Doctor'
Insert into TempReasonMaster Select'Doctor Self and Immediate family','El Doctor mismo y Familia inmediata'
Insert into TempReasonMaster Select'Doctors Prescription : Special Request from Doctor','Prescripciones del Doctor: Solicitud especial del Doctor'
Insert into TempReasonMaster Select'Doctors Prescription : mentioning Maximum Discount','Prescripciones del Doctor: Mencionando Descuento Máximo'
Insert into TempReasonMaster Select'Doctors Prescription : mentioning Minimum Discount','Prescripciones del Doctor: Mencionando Descuento Mínimo'
Insert into TempReasonMaster Select'Doctors Relative','Pariente del Doctor'
Insert into TempReasonMaster Select'Dry swab received for (Acid Fast Bacilli) or anaerobic culture','Muestra en hisopo recibido (para Bacilos ácido-alcohol) ó cultivo anaeróbico'
Insert into TempReasonMaster Select'Duplicate Registration','Registro Duplicado'
Insert into TempReasonMaster Select'Employe Relation','Relación con el Empleado'
Insert into TempReasonMaster Select'Employee reference','Referencia del Empleado'
Insert into TempReasonMaster Select'Fluid/ separated plasma type not mentioned','Fluído / Tipo de plasma separado no mencionado'
Insert into TempReasonMaster Select'Frozen Sample - Thawed','Muestra Congelada - Descongelada'
Insert into TempReasonMaster Select'Government Official','Oficial Gubernamental'
Insert into TempReasonMaster Select'Govt Officials','Oficiales del Gobierno'
Insert into TempReasonMaster Select'Haemolysed sample','Muestra hemolizada'
Insert into TempReasonMaster Select'Histo sample received in Saline','Muestra histopatológica recibida en solución salina'
Insert into TempReasonMaster Select'History incomplete for Histopathology','Historia incompleta para Histopatogía'
Insert into TempReasonMaster Select'Height & weight not given for Creatinine Clearance test','Altura y Peso no entregadas para prueba de Depuración de Creatinina'
Insert into TempReasonMaster Select'Icteric Sample','Muestra ictérica'
Insert into TempReasonMaster Select'Improper documents received(form,history,specimen)','Documentos incorrectos recibidos (forma, historia, muestra)'
Insert into TempReasonMaster Select'Inactivate test code due to discontinue','Código de prueba inactivo debido a descontinuidad'
Insert into TempReasonMaster Select'Inappropriate Container','Recipiente inadecuado'
Insert into TempReasonMaster Select'Inappropriate Patient Preparation','Preparación del Paciente inadecuada'
Insert into TempReasonMaster Select'Invoice Cancel','Factura Cancelada'
Insert into TempReasonMaster Select'Kit Not Available','Botiquín no disponible'
Insert into TempReasonMaster Select'Lipemic Sample','Muestra lipémica'
Insert into TempReasonMaster Select'Management Approval','Aprobación de Gerencia'
Insert into TempReasonMaster Select'Management Approval : CXO','Aprobación de Gerencia: CXO'
Insert into TempReasonMaster Select'Management Approval : PCH','Aprobación de Gerencia: PCH'
Insert into TempReasonMaster Select'Marketing Camps','Campañas de Mercadeo'
Insert into TempReasonMaster Select'Marketing Special Events','Eventos Especiales de Mercadeo'
Insert into TempReasonMaster Select'Medical Correlation','Correlación Médica'
Insert into TempReasonMaster Select'Microclot Seen','Microcoagulación vista'
Insert into TempReasonMaster Select'Missing Patient','Paciente no acudió a una consulta.'
Insert into TempReasonMaster Select'Non-Cooperative Patient','Paciente no cooperativo'
Insert into TempReasonMaster Select'PANACEA DISCOUNT','Descuentos por Panacea'
Insert into TempReasonMaster Select'Patient Delay','Paciente retrasado'
Insert into TempReasonMaster Select'Patient in Sick','Paciente enfermo'
Insert into TempReasonMaster Select'Patient name mismatch on sample & on Test Request Form','El nombre del paciente no coincide con la muestra y/o la Forma de Solicitud de Prueba'
Insert into TempReasonMaster Select'Patient Not Available','Paciente no Disponible'
Insert into TempReasonMaster Select'Patient''s name not mentioned on sample tube','Nombre del Paciente no mencionado en el tubo de muestra'
Insert into TempReasonMaster Select'Quantity Not Sufficent (Q.N.S)','Cantidad Insuficiente'
Insert into TempReasonMaster Select'Quantity Not Sufficent (Q.N.S) For Recheck','Cantidad Insuficiente a verificar nuevamente'
Insert into TempReasonMaster Select'QC - QUALITY CONTROL','Control de Calidad'
Insert into TempReasonMaster Select'QNS or Sample Not Recieved & test want to cancelled & should','Cantidad insuficiente o muestra no recibida y prueba requiere ser cancelada'
Insert into TempReasonMaster Select'Rate Correction Discounts','Descuentos por corrección de tarifas'
Insert into TempReasonMaster Select'Rate Master Updation','Actualización de tarifas principales'
Insert into TempReasonMaster Select'Recheck Sample','Muestra verificada nuevamente'
Insert into TempReasonMaster Select'Referance correction','Corrección de referencias'
Insert into TempReasonMaster Select'REGISTRATION ERRORS','Registro de errores'
Insert into TempReasonMaster Select'Repeat Sample','Repetición de Muestra'
Insert into TempReasonMaster Select'Request received through mail hold till time confirmation','Solicitud recibida por correo y en espera de ser confirmada'
Insert into TempReasonMaster Select'Result Correlation Error','Resultado de correlación de error'
Insert into TempReasonMaster Select'Sales Approval','Aprobació de Ventas'
Insert into TempReasonMaster Select'Sample Integrity Questionable/Contaminated','Integridad de la muestra es cuestionable/está contaminada'
Insert into TempReasonMaster Select'Sample not received (S.N.R)','Muestra no recibida'
Insert into TempReasonMaster Select'Sample Quality Inappropriate','Calidad de la Muestra inadecuada'
Insert into TempReasonMaster Select'Sample collected in expiry vial','Fecha de Vencimiento en el envase de la muestra recogida'
Insert into TempReasonMaster Select'Sample received in appropriate temperature','Muestra recibida a temperatura adecuada'
Insert into TempReasonMaster Select'Sample reject as per request','Muestra rechazada según solicitud.'
Insert into TempReasonMaster Select'Senior Management Approval','Aprobación de Alta Gerencia'
Insert into TempReasonMaster Select'Spot urine instead of 24 hrs urine','Prueba rápida de orina en lugar de orina de 24 horas'
Insert into TempReasonMaster Select'Stability out','Sin estabilidad'
Insert into TempReasonMaster Select'Stone type not mentioned','Tipo de piedra no mencionada'
Insert into TempReasonMaster Select'System Error','Error del Sistema'
Insert into TempReasonMaster Select'Test Cancelled','Prueba Cancelada'
Insert into TempReasonMaster Select'Test code not active','Código de prueba inactivo'
Insert into TempReasonMaster Select'Test Deactivated','Prueba desactivada'
Insert into TempReasonMaster Select'Test name test code mismatch','Nombre y código de prueba desigual.'
Insert into TempReasonMaster Select'Test Request on Hold','Solicitud de Prueba en espera'
Insert into TempReasonMaster Select'Test Result For Sample having Error from Machine','Resultado de la prueba para muestra presenta error de la máquina'
Insert into TempReasonMaster Select'Test want to be cancelled before processing','Se requiere cancelar la prueba antes de ser procesada'
Insert into TempReasonMaster Select'TestMaster Updation','Actualización de Prueba principal'
Insert into TempReasonMaster Select'Triple history not given (ultrasonogram report)','Historia triple no entregada (informe de ultrasonograma)'
Insert into TempReasonMaster Select'Unable to process','No se puede procesar'
Insert into TempReasonMaster Select'Wrong client selected','Cliente incorrecto seleccionado'
Insert into TempReasonMaster Select'Wrong lab taken','Obtenidos de laboratorio incorrectos'
Insert into TempReasonMaster Select'Wrong Registration','Registro incorrecto'
Insert into TempReasonMaster Select'Wrong sample','Muestra incorrecta'
Insert into TempReasonMaster Select'Wrong test selected','Prueba incorrecta seleccionada'

alter table reasonmaster
drop constraint PK__ReasonMa__A4F8C0C700B50445

declare @language nvarchar(20) = 'es-ES'
Declare @OrgID bigint=86

SET IDENTITY_INSERT ReasonMaster ON 
insert into ReasonMaster (ReasonID ,ReasonTypeID ,Reason ,ReasonCode ,Status ,langcode)
select  RM.ReasonID ,RM.ReasonTypeID ,tbl.chinesechar ,RM.ReasonCode ,RM.Status ,@language from ReasonMaster RM
inner join TempReasonMaster tbl on tbl.Name =RM.reason--where status='A'-- and orgid=@OrgID 
SET IDENTITY_INSERT ReasonMaster OFF 





--------------------------Task Actions-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


update taskactions set displaytexttemplate='Aprobar resultado de investigación para {PatientName} ({PatientNumber}) (Número de visita: {VisitNumber})' where  LanguageCode='es-es' and TaskActionID =62
update taskactions set displaytexttemplate='Aprobar resultado de investigación para {PatientName} ({PatientNumber}) (Número de visita: {VisitNumber})'  where  LanguageCode='es-es' and TaskActionID =74
update taskactions set displaytexttemplate='Aprobar resultado de investigación para {PatientName} ({PatientNumber}) (Número de visita: {VisitNumber})' where  LanguageCode='es-es' and TaskActionID =75
update taskactions set displaytexttemplate='debido a cancelación Aprobación para {PatientName} ({PatientNumber})' where  LanguageCode='es-es' and TaskActionID =77
update taskactions set displaytexttemplate='Autorizacion selectiva para {PatientName} (Número de pacientes: {PatientNumber}) (Número de visita: {VisitNumber})'  where  LanguageCode='es-es' and TaskActionID =78
update taskactions set displaytexttemplate='Introducir resultado para {PatientName} (PatientNo: {PatientNumber}) (LabNumber: {ExternalVisitID})'  where  LanguageCode='es-es' and TaskActionID =86
update taskactions set displaytexttemplate='Introducir resultado para {PatientName} (Número de paciente: {PatientNumber}) (Número de visita: {VisitNumber})'  where  LanguageCode='es-es' and TaskActionID =63
update taskactions set displaytexttemplate='Validar resultado de investigación para {PatientName} ({PatientNumber}) (Número de visita: {VisitNumber})'  where  LanguageCode='es-es' and TaskActionID =39
update taskactions set displaytexttemplate='Co-autorizar para {PatientName} (Número de paciente: {PatientNumber}) (Número de visita: {VisitNumber})'  where  LanguageCode='es-es' and TaskActionID =67
update taskactions set displaytexttemplate='Recibir muestra para {PatientName} (Número de paciente: {PatientNumber}) (Número de visita: {VisitNumber})'  where  LanguageCode='es-es' and TaskActionID =68
update taskactions set displaytexttemplate='Recoger muestra para {PatientName} ({PatientNumber})'  where  LanguageCode='es-es' and TaskActionID =26
update taskactions set displaytexttemplate='Recoger muestra para  {PatientName}({PatientNumber})(Número de visita:{VisitNumber})'  where  LanguageCode='es-es' and TaskActionID =22

----------------------------------------------------------End --------------------------------------------------------------------------------------------------------------------------------------------------------------
































































































































































































































































