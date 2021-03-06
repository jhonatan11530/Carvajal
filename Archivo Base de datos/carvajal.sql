USE [carvajal]
GO
/****** Object:  User [carvajal]    Script Date: 20-feb-22 3:37:49 PM ******/
CREATE USER [carvajal] FOR LOGIN [carvajal] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 20-feb-22 3:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[usuario] [varchar](6) NOT NULL,
	[contraseña] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vuelos]    Script Date: 20-feb-22 3:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  StoredProcedure [dbo].[NewDeleteCommand]    Script Date: 20-feb-22 3:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewDeleteCommand]
(
	@Original_id int,
	@p2 int,
	@Original_Ciudad_origen varchar(30),
	@Original_Ciudad_destino varchar(30)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [vuelos] WHERE (([id] = @Original_id) AND ([nvuelo] = @p2) AND ([ciudad_origen] = @Original_Ciudad_origen) AND ([ciudad_destino] = @Original_Ciudad_destino))
GO
/****** Object:  StoredProcedure [dbo].[NewInsertCommand]    Script Date: 20-feb-22 3:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewInsertCommand]
(
	@aerolinea text,
	@p1 int,
	@Ciudad_origen varchar(30),
	@Hora_salida text,
	@Ciudad_destino varchar(30),
	@Hora_entrada text,
	@fecha text,
	@estado text
)
AS
	SET NOCOUNT OFF;
INSERT INTO [vuelos] ([aerolinea], [nvuelo], [ciudad_origen], [hora_salida], [ciudad_destino], [hora_entrada], [fecha], [estado]) VALUES (@aerolinea, @p1, @Ciudad_origen, @Hora_salida, @Ciudad_destino, @Hora_entrada, @fecha, @estado);
	
SELECT id, aerolinea, nvuelo AS [N° Vuelos], ciudad_origen AS [Ciudad origen], hora_salida AS [Hora salida], ciudad_destino AS [Ciudad destino], hora_entrada AS [Hora entrada], fecha, estado FROM vuelos WHERE (id = SCOPE_IDENTITY())
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 20-feb-22 3:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        id, aerolinea, nvuelo AS [N° Vuelos], ciudad_origen AS [Ciudad origen], hora_salida AS [Hora salida], ciudad_destino AS [Ciudad destino], hora_entrada AS [Hora entrada], fecha, estado
FROM            vuelos
GO
/****** Object:  StoredProcedure [dbo].[NewUpdateCommand]    Script Date: 20-feb-22 3:37:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NewUpdateCommand]
(
	@aerolinea text,
	@p1 int,
	@Ciudad_origen varchar(30),
	@Hora_salida text,
	@Ciudad_destino varchar(30),
	@Hora_entrada text,
	@fecha text,
	@estado text,
	@Original_id int,
	@p2 int,
	@Original_Ciudad_origen varchar(30),
	@Original_Ciudad_destino varchar(30),
	@id int
)
AS
	SET NOCOUNT OFF;
UPDATE [vuelos] SET [aerolinea] = @aerolinea, [nvuelo] = @p1, [ciudad_origen] = @Ciudad_origen, [hora_salida] = @Hora_salida, [ciudad_destino] = @Ciudad_destino, [hora_entrada] = @Hora_entrada, [fecha] = @fecha, [estado] = @estado WHERE (([id] = @Original_id) AND ([nvuelo] = @p2) AND ([ciudad_origen] = @Original_Ciudad_origen) AND ([ciudad_destino] = @Original_Ciudad_destino));
	
SELECT id, aerolinea, nvuelo AS [N° Vuelos], ciudad_origen AS [Ciudad origen], hora_salida AS [Hora salida], ciudad_destino AS [Ciudad destino], hora_entrada AS [Hora entrada], fecha, estado FROM vuelos WHERE (id = @id)
GO
