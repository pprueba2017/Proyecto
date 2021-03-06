USE [Proyecto_ADI]
GO
/****** Object:  Table [dbo].[Actividades]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actividades](
	[Id_Actividades] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Actividad] [varchar](45) NOT NULL,
	[Fecha_Actividad] [datetime] NOT NULL,
	[Id_Afiliado] [int] NOT NULL,
	[Monto_Total_Inversion] [float] NOT NULL,
	[Monto_Total_Recuperado] [float] NOT NULL,
	[Utilidad_Total] [float] NOT NULL,
	[Tipo_Actividades] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Actividades] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Afiliados]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Afiliados](
	[Id_Afiliado] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Apellido1] [varchar](40) NOT NULL,
	[Apellido2] [varchar](40) NOT NULL,
	[Direccion] [varchar](260) NOT NULL,
	[Edad] [int] NOT NULL,
	[Telefono] [int] NULL,
	[Correo] [varchar](100) NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Estado] [nchar](10) NULL,
 CONSTRAINT [PK__Afiliado__064ACA6E105A65B9] PRIMARY KEY CLUSTERED 
(
	[Id_Afiliado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Asigna_Afiliados_Proyectos]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asigna_Afiliados_Proyectos](
	[IdAsigna_Afiliados] [int] IDENTITY(1,1) NOT NULL,
	[Id_Proyecto] [int] NOT NULL,
	[Id_Afiliado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdAsigna_Afiliados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Asignacion_Recursos]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignacion_Recursos](
	[idAsignacion_Recursos] [int] IDENTITY(1,1) NOT NULL,
	[Id_Proyecto] [int] NOT NULL,
	[Id_Recursos_necesario] [int] NOT NULL,
	[Id_cronograma] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAsignacion_Recursos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cronograma_Proyectos]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cronograma_Proyectos](
	[Id_Cronograma_Proyectos] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Cronograma] [varchar](300) NOT NULL,
	[Fecha_Inicio] [datetime] NOT NULL,
	[Estado] [varchar](10) NOT NULL,
	[Fecha_Final] [datetime] NOT NULL,
	[Id_Proyecto] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cronograma_Proyectos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Donaciones]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Donaciones](
	[Id_Donaciones] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Doante] [varchar](155) NOT NULL,
	[Monto] [int] NOT NULL,
	[Descripcion] [varchar](200) NOT NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Donaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Instituciones]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Instituciones](
	[Id_Institucion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Cedula_Juridica] [int] NOT NULL,
	[Descripcion_Institucion] [varchar](300) NOT NULL,
	[Direccion] [varchar](260) NOT NULL,
	[Representante_Legal_Institucion] [varchar](75) NOT NULL,
	[Nombre_Encargado] [varchar](75) NULL,
	[Correo] [varchar](100) NOT NULL,
	[Telefono] [int] NOT NULL,
 CONSTRAINT [PK__Instituc__86BD760F368C85D9] PRIMARY KEY CLUSTERED 
(
	[Id_Institucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JuntaDirectiva]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[JuntaDirectiva](
	[Id_JuntaDirectiva] [int] IDENTITY(1,1) NOT NULL,
	[Id_Afiliado] [int] NOT NULL,
	[Nombre_Puesto_Junta] [varchar](20) NOT NULL,
	[Periodo] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_JuntaDirectiva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Presupuesto_de_Actividades]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presupuesto_de_Actividades](
	[Id_Presupuesto_de_Actividades] [int] IDENTITY(1,1) NOT NULL,
	[Id_Actividades] [int] NULL,
	[Capital] [int] NOT NULL,
	[Id_Donacion] [int] NULL,
	[Fecha] [datetime] NULL,
	[Id_Proyecto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Presupuesto_de_Actividades] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proyectos]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proyectos](
	[Id_Proyecto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Proyecto] [varchar](150) NOT NULL,
	[Descripcion_Proyecto] [varchar](500) NOT NULL,
	[Direccion_exacta] [varchar](260) NOT NULL,
	[Justificacion] [varchar](500) NOT NULL,
	[Numero_Folio_Real] [varchar](100) NOT NULL,
	[Numero_Libro_Acta] [varchar](300) NOT NULL,
	[Costo_Real] [int] NOT NULL,
	[Presupuesto_Aprovado] [int] NOT NULL,
	[Aporte_comunidad] [int] NOT NULL,
	[Representante_Junta_Legal] [int] NOT NULL,
	[Estado_Proyecto] [varchar](15) NOT NULL,
	[Id_Recursos_Necesario] [int] NOT NULL,
	[Id_Institucion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Recursos_Necesarios]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Recursos_Necesarios](
	[Id_Recursos_necesario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Recurso] [varchar](250) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Descripcion] [varchar](450) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Recursos_necesario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/10/2017 6:59:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Usuarios] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Usuario] [varchar](20) NOT NULL,
	[Id_JuntaDirectiva] [int] NOT NULL,
	[Perfil] [varchar](15) NOT NULL,
	[Clave] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Usuarios__AEF904296062B810] PRIMARY KEY CLUSTERED 
(
	[Id_Usuarios] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Actividades]  WITH CHECK ADD  CONSTRAINT [FK_Actividades_Afiliados] FOREIGN KEY([Id_Afiliado])
REFERENCES [dbo].[Afiliados] ([Id_Afiliado])
GO
ALTER TABLE [dbo].[Actividades] CHECK CONSTRAINT [FK_Actividades_Afiliados]
GO
ALTER TABLE [dbo].[Asigna_Afiliados_Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Asigna_Afiliados_Proyectos_Afiliados] FOREIGN KEY([Id_Afiliado])
REFERENCES [dbo].[Afiliados] ([Id_Afiliado])
GO
ALTER TABLE [dbo].[Asigna_Afiliados_Proyectos] CHECK CONSTRAINT [FK_Asigna_Afiliados_Proyectos_Afiliados]
GO
ALTER TABLE [dbo].[Asigna_Afiliados_Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Asigna_Afiliados_Proyectos_Proyectos] FOREIGN KEY([Id_Proyecto])
REFERENCES [dbo].[Proyectos] ([Id_Proyecto])
GO
ALTER TABLE [dbo].[Asigna_Afiliados_Proyectos] CHECK CONSTRAINT [FK_Asigna_Afiliados_Proyectos_Proyectos]
GO
ALTER TABLE [dbo].[Asignacion_Recursos]  WITH CHECK ADD  CONSTRAINT [FK_Asignacion_Recursos_Cronograma_Proyectos] FOREIGN KEY([Id_cronograma])
REFERENCES [dbo].[Cronograma_Proyectos] ([Id_Cronograma_Proyectos])
GO
ALTER TABLE [dbo].[Asignacion_Recursos] CHECK CONSTRAINT [FK_Asignacion_Recursos_Cronograma_Proyectos]
GO
ALTER TABLE [dbo].[Asignacion_Recursos]  WITH CHECK ADD  CONSTRAINT [FK_Asignacion_Recursos_Proyectos] FOREIGN KEY([Id_Proyecto])
REFERENCES [dbo].[Proyectos] ([Id_Proyecto])
GO
ALTER TABLE [dbo].[Asignacion_Recursos] CHECK CONSTRAINT [FK_Asignacion_Recursos_Proyectos]
GO
ALTER TABLE [dbo].[Asignacion_Recursos]  WITH CHECK ADD  CONSTRAINT [FK_Asignacion_Recursos_Recursos_Necesarios] FOREIGN KEY([Id_Recursos_necesario])
REFERENCES [dbo].[Recursos_Necesarios] ([Id_Recursos_necesario])
GO
ALTER TABLE [dbo].[Asignacion_Recursos] CHECK CONSTRAINT [FK_Asignacion_Recursos_Recursos_Necesarios]
GO
ALTER TABLE [dbo].[JuntaDirectiva]  WITH CHECK ADD  CONSTRAINT [FK_JuntaDirectiva_Afiliados1] FOREIGN KEY([Id_Afiliado])
REFERENCES [dbo].[Afiliados] ([Id_Afiliado])
GO
ALTER TABLE [dbo].[JuntaDirectiva] CHECK CONSTRAINT [FK_JuntaDirectiva_Afiliados1]
GO
ALTER TABLE [dbo].[Presupuesto_de_Actividades]  WITH CHECK ADD  CONSTRAINT [FK_Presupuesto_de_Actividades_Actividades] FOREIGN KEY([Id_Actividades])
REFERENCES [dbo].[Actividades] ([Id_Actividades])
GO
ALTER TABLE [dbo].[Presupuesto_de_Actividades] CHECK CONSTRAINT [FK_Presupuesto_de_Actividades_Actividades]
GO
ALTER TABLE [dbo].[Presupuesto_de_Actividades]  WITH CHECK ADD  CONSTRAINT [FK_Presupuesto_de_Actividades_Donaciones] FOREIGN KEY([Id_Donacion])
REFERENCES [dbo].[Donaciones] ([Id_Donaciones])
GO
ALTER TABLE [dbo].[Presupuesto_de_Actividades] CHECK CONSTRAINT [FK_Presupuesto_de_Actividades_Donaciones]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Instituciones] FOREIGN KEY([Id_Institucion])
REFERENCES [dbo].[Instituciones] ([Id_Institucion])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Instituciones]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_JuntaDirectiva] FOREIGN KEY([Id_JuntaDirectiva])
REFERENCES [dbo].[JuntaDirectiva] ([Id_JuntaDirectiva])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_JuntaDirectiva]
GO
