#PRUEBA TECNICA CARVAJAL 2022
prueba tecnica carvajal 2022 JHONATAN FERNANDEZ MUÑOZ

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
