USE [DBSISTEMA_HOTELERIA]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 1/12/2023 10:35:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[ID_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Dni_cliente] [int] NULL,
	[Nombre_cliente] [varchar](50) NOT NULL,
	[Cuit_cuil] [varchar](50) NULL,
	[Apellido_cliente] [varchar](50) NOT NULL,
	[Fecha_nacimiento] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Localidad] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Nacionalidad] [varchar](50) NULL,
	[Correo] [varchar](50) NULL,
 CONSTRAINT [PK__CLIENTE__9BB2655BA0ED1874] PRIMARY KEY CLUSTERED 
(
	[ID_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RESERVA]    Script Date: 1/12/2023 10:35:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESERVA](
	[Cod_reserva] [int] IDENTITY(1,1) NOT NULL,
	[ID_cliente] [int] NOT NULL,
	[Cant_noches] [int] NOT NULL,
	[Cant_habitaciones] [int] NOT NULL,
	[Cant_adultos] [int] NOT NULL,
	[Cant_menores] [int] NOT NULL,
	[Tipo_habitacion] [varchar](50) NOT NULL,
	[Check_in] [datetime] NULL,
	[Check_out] [datetime] NOT NULL,
	[Tipo_cama] [varchar](50) NULL,
	[Monto_aproximado] [int] NOT NULL,
 CONSTRAINT [PK__RESERVA__E41F0174420B9788] PRIMARY KEY CLUSTERED 
(
	[Cod_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RESERVA] ADD  CONSTRAINT [DF__RESERVA__Check_i__276EDEB3]  DEFAULT (getdate()) FOR [Check_in]
GO
ALTER TABLE [dbo].[RESERVA]  WITH CHECK ADD  CONSTRAINT [FK__RESERVA__DNI_cli__267ABA7A] FOREIGN KEY([ID_cliente])
REFERENCES [dbo].[CLIENTE] ([ID_cliente])
GO
ALTER TABLE [dbo].[RESERVA] CHECK CONSTRAINT [FK__RESERVA__DNI_cli__267ABA7A]
GO
