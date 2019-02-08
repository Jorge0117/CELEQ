SELECT CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Estudiante,
 E.id as Identificación, D.modalidad as Modalidad, D.horas as Horas, 
 D.encargado as Responsable, D.unidad as Unidad, P.numero as P9 from estudiante E join
 designacionAsistencia D on E.id = D.idEstudiante
 join p9 P on P.idDesignacion = D.id 
 where P.ultimoAgregado = 1

 select top 1 id from p9 order by id desc 
 select * from p9

 select * from Unidad

 delete from designacionAsistencia 
 where modalidad = 'H.E'

 delete from p9
 where numero = 'egfs5hyg343'

 update designacionAsistencia
 set modalidad = 'H.E'
 where idEstudiante = '207800503'

 select * from designacionAsistencia

 select * from RepDesignaciones

 SELECT * FROM RepDesignaciones R
 JOIN designacionAsistencia D ON R.Id = D.id
 WHERE D.ano = 2018

SELECT        R.Estudiante, R.Identificación, R.Modalidad, R.Horas, R.Responsable, R.Unidad, R.P9
FROM            RepDesignaciones AS R INNER JOIN
                         designacionAsistencia AS D ON R.Id = D.id
WHERE        (D.ano = 2018)
AND D.ciclo = 'III'


 insert into p9 values(newId(), null, null, 354156, 8, GETDATE())

 SELECT id, ano, ciclo, fechaInicio, fechafinal, convocatoria,
  horas, modalidad, monto, inopia, motivoInopia, tramitado, observaciones,
   idEstudiante, presupuesto, encargado, unidad FROM dbo.designacionAsistencia

create view RepDesignaciones as 
SELECT CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Estudiante, D.id as Id,
 E.id as Identificación, D.modalidad as Modalidad, D.horas as Horas, 
 D.encargado as Responsable, D.unidad as Unidad, P.numero as P9,D.presupuesto, D.ciclo, D.ano from estudiante E join
 designacionAsistencia D on E.id = D.idEstudiante
 join p9 P on P.idDesignacion = D.id 
 where P.ultimoAgregado = 1;

 select * from RepDesignaciones

select top 1 * from p9   where idDesignacion = 8  order by fecha desc

alter table p9 add bitNewest bool 

declare @fecha datetime
select @fecha = max(fecha) from p9 where idDesignacion = 8
 select numero as P9 from p9 where fecha = @fecha and idDesignacion = 8

SELECT CONCAT(E.nombre, ' ', E.apellido1, ' ', E.apellido2) as Estudiante,
 E.id as Identificación, D.modalidad as Modalidad, D.horas as Horas, 
 D.encargado as Responsable, D.unidad as Unidad from estudiante E join
 designacionAsistencia D on E.id = D.idEstudiante where D.id = 8
 union
 select numero as P9 from p9 where fecha = @fecha and idDesignacion = 8

 select * from designacionAsistencia
 SELECT R.Estudiante, R.Identificación, R.Modalidad, R.Horas, R.Responsable, R.Unidad, R.P9, R.Id, R.ciclo FROM RepDesignaciones AS R INNER JOIN designacionAsistencia AS D ON R.Id = D.id WHERE (D.ano = 2018) group by ano