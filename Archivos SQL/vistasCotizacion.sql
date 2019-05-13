CREATE VIEW vistaCotizacion 
AS
SELECT        C.nombre, C.telefono, C.telefono2, C.correo, Con.atencionDe, Co.id, Co.anno, Co.precioMuestreo, Co.precioMuestra, Co.descuento, Co.gastosAdm, Co.saldoAfavor, Co.diasEntregaRes, Co.granTotal, 
                         Co.observaciones, Co.subTotal, Co.numeroMuestras
FROM            dbo.ClienteCotizacion AS C INNER JOIN
                         dbo.ContactoCotizacion AS Con ON C.nombre = Con.nombreCliente INNER JOIN
                         dbo.Cotizacion AS Co ON Co.cliente = C.nombre INNER JOIN
                         dbo.CotizacionAnalisis AS CA ON CA.idCotizacion = Co.id AND CA.annoCotizacion = Co.anno INNER JOIN
                         dbo.Analisis AS A ON A.descripcion = CA.descripcion AND A.tipoAnalisis = CA.tipoAnalisis INNER JOIN
                         dbo.tipoAnalisis AS T ON T.tipo = A.tipoAnalisis
drop VIEW vistaCotizacion

CREATE VIEW vistaAnalisis
AS
SELECT        Co.id, Co.anno, A.descripcion, A.metodo, A.precio, A.acreditacion
FROM            dbo.Analisis AS A INNER JOIN
                         dbo.CotizacionAnalisis AS C ON A.descripcion = C.descripcion AND A.tipoAnalisis = C.tipoAnalisis INNER JOIN
                         dbo.Cotizacion AS Co ON Co.id = C.idCotizacion AND Co.anno = C.annoCotizacion

CREATE VIEW vistaTransferenciaDeMuestras
AS

select * from Cotizacion
select CONCAT('CELEQ-VE-',FORMAT(Co.id, 'D4'),'-',Co.anno) as 'Consecutivo', C.nombre, Co.fechaCotizacion from Cotizacion Co
join ClienteCotizacion C on Co.cliente = C.nombre
where CONCAT('CELEQ-VE-',FORMAT(Co.id, 'D4'),'-',anno) like '%001-2019%' 
order by anno, id

