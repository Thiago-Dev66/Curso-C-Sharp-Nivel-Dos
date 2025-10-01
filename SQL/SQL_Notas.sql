-- SQL Query

-- Hay cuatro consultas basicas: 

-- LEER --

-- "select" para leer  "*" para seleccionar todo "from" (tabla)

select * from TIPOSEDICION
select * from DISCOS
select Titulo, CantidadCanciones, Descripcion from DISCOS, ESTILOS --Devuelve columas especificas de una tabla.
select * from ESTILOS
-- "where" es un condicional:
-- Podemos usar concatenadores logicos: AND y OR

select * from DISCOS where idestilo = 2 AND CantidadCanciones = 12

select D.Titulo, D.CantidadCanciones, E.Descripcion as Estilo from DISCOS D, ESTILOS E -- "E" y "D" son seudonimos
where D.IdEstilo = E.Id 

-- INSERTAR --

-- "insert" para escribir en la base de datos

insert into DISCOS (Titulo, CantidadCanciones) values ('Powerslave', 10) --para cargar nuevo/s elemento/s
--otra forma:
insert into DISCOS values
('Killers', GETDATE(), 9, 'https...', 2, 3 ) --cargamos los elementos de todas las columnas.

-- MODIFICAR --

update ESTILOS set Descripcion = 'Country' /* MUY IMPORTANTE USAR "WHERE" */ where id = 1
select D.Titulo, D.Titulo, E.Descripcion as estilo from DISCOS D, ESTILOS E

-- ELIMINAR --

delete from DISCOS WHERE id = 5

--OTROS COMANDOS

-- Inicio una transacción
BEGIN TRANSACTION;

-- Si estoy conforme:
COMMIT;

-- Si me equivoqué:
ROLLBACK;
