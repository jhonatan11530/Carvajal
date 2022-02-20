#PRUEBA TECNICA CARVAJAL 2022 <br>
prueba tecnica carvajal 2022 

#ENTORNO DE DESARROLLO
<p align="center">
<a><img src="https://github.com/jhonatan11530/jhonatan11530.github.io/blob/gh-pages/assets/img/Visual_Studio.svg" width="180" height="180"></a>
</p>
#BASE DE DATOS USADO PARA EL DESARROLLO
la base de datos usada es SQL SERVER 2019
<p align="center">
<a><img src="https://github.com/jhonatan11530/jhonatan11530.github.io/blob/gh-pages/assets/img/sqlserver.svg" width="180" height="180"></a>
</p>

#CONFIGURACION DE BASE DE DATOS

```
SERVER : LOCALHOST
NAME DATABASE: carvajal
USER: carvajal
PWD : carvajal
```

#SCRIPT BASE DE DATOS

crear base de datos

```
CREATE DATABASE PRUEBA
```

#SCRIPT usados en el proyecto

```
script para actualizar el datagridview del control de estado de vuelo
Select count(id) as id from vuelos where estado Like 'Salida'


script para eliminar el registro de vuelo
DELETE FROM vuelos WHERE id=ID_VUELO

script para actualizar el datagridview en el panel administrador
Select count(id) as id from vuelos

script para insertar los datos en la base de datos (Crear vuelo)
INSERT INTO vuelos(ciudad_origen, ciudad_destino, fecha, hora_salida, hora_entrada, nvuelo, aerolinea, estado) VALUES ()

script para editar vuelos y actualizar
"UPDATE vuelos SET nvuelo= '" + Nvuelo.Text + "',aerolinea= '" + Aerolinia.Text + "',ciudad_origen= '" + Corigen.Text + "',hora_salida= '" + HoraSalida.Text + "',ciudad_destino='" + Cdestino.Text + "',hora_entrada='" + Horallegada.Text + "',fecha='" + fecha.Text + "',estado='" + item + "' WHERE id= '" + index + "';";

script para visualizar los vuelos
SELECT * FROM vuelos WHERE id='ID_VUELO'

```

crea la tabla usuario para el sistema de login

```
CREATE TABLE [dbo].[usuario](
	[usuario] [varchar](6) NOT NULL,
	[contraseña] [int] NULL
) ON [PRIMARY]
GO
```

crea la tabla vuelo para el registro de vuelos

```
CREATE TABLE [dbo].[vuelos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nvuelo] [int] NOT NULL,
	[aerolinea] [text] NOT NULL,
	[ciudad_origen] [varchar](30) NOT NULL,
	[hora_salida] [text] NOT NULL,
	[ciudad_destino] [varchar](30) NOT NULL,
	[hora_entrada] [text] NOT NULL,
	[fecha] [text] NOT NULL,
	[estado] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
```
