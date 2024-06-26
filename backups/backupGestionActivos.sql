create database [DBGestionActivos]
go
USE [DBGestionActivos]
GO
/****** Object:  User [ManuelMJLG_SQLLogin_1]    Script Date: 2/4/2024 15:03:51 ******/
CREATE USER [ManuelMJLG_SQLLogin_1] FOR LOGIN [ManuelMJLG_SQLLogin_1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [ManuelMJLG_SQLLogin_1]
GO
/****** Object:  Schema [Acce]    Script Date: 2/4/2024 15:03:51 ******/
CREATE SCHEMA [Acce]
GO
/****** Object:  Schema [Acti]    Script Date: 2/4/2024 15:03:51 ******/
CREATE SCHEMA [Acti]
GO
/****** Object:  Schema [Empr]    Script Date: 2/4/2024 15:03:51 ******/
CREATE SCHEMA [Empr]
GO
/****** Object:  Schema [Gnrl]    Script Date: 2/4/2024 15:03:51 ******/
CREATE SCHEMA [Gnrl]
GO
/****** Object:  Schema [ManuelMJLG_SQLLogin_1]    Script Date: 2/4/2024 15:03:51 ******/
CREATE SCHEMA [ManuelMJLG_SQLLogin_1]
GO
/****** Object:  Table [Acce].[tbPantallas]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbPantallas](
	[Pant_Id] [int] IDENTITY(1,1) NOT NULL,
	[Pant_Descripcion] [varchar](30) NULL,
 CONSTRAINT [PK_Pant_Id] PRIMARY KEY CLUSTERED 
(
	[Pant_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbPantallasPorRoles]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbPantallasPorRoles](
	[PaRo_Id] [int] IDENTITY(1,1) NOT NULL,
	[Role_Id] [int] NULL,
	[Pant_Id] [int] NULL,
	[PaRo_UsuarioCreacion] [int] NULL,
	[PaRo_FechaCreacion] [datetime] NULL,
	[PaRo_UsuarioModificacion] [int] NULL,
	[PaRo_FechaModificacion] [datetime] NULL,
	[PaRo_Estado] [bit] NULL,
 CONSTRAINT [PK_PaRo_Id] PRIMARY KEY CLUSTERED 
(
	[PaRo_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbRoles]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbRoles](
	[Role_Id] [int] IDENTITY(1,1) NOT NULL,
	[Role_Descripcion] [varchar](30) NULL,
	[Role_UsuarionCreacion] [int] NULL,
	[Role_FechaCreacion] [datetime] NULL,
	[Role_UsuarioModificacion] [int] NULL,
	[Role_FechaModificacion] [datetime] NULL,
	[Role_Estado] [bit] NULL,
 CONSTRAINT [PK_Role_Id] PRIMARY KEY CLUSTERED 
(
	[Role_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acce].[tbUsuario]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acce].[tbUsuario](
	[Usua_Id] [int] IDENTITY(1,1) NOT NULL,
	[Usua_Nombre] [varchar](30) NULL,
	[Usua_Contra] [varchar](max) NULL,
	[Usua_Admin] [bit] NULL,
	[Usua_Activo] [bit] NULL,
	[Usua_FechaCreacion] [datetime] NULL,
	[Usua_FechaModificacion] [datetime] NULL,
	[Usua_UsuarionCreacion] [int] NULL,
	[Usua_UsuarionModificacion] [int] NULL,
 CONSTRAINT [PK_Usua_Id] PRIMARY KEY CLUSTERED 
(
	[Usua_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Acti].[tbActivos]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acti].[tbActivos](
	[Acti_Id] [int] IDENTITY(1,1) NOT NULL,
	[Acti_Url] [varchar](90) NULL,
	[Acti_Descripcion] [varchar](30) NULL,
	[Acti_Precio] [numeric](8, 2) NULL,
	[Acti_Marca] [varchar](30) NULL,
	[Acti_Modelo] [varchar](30) NULL,
	[Acti_NoSerio] [varchar](20) NULL,
	[Empl_Id] [int] NULL,
	[VidU_Id] [int] NULL,
	[Acti_FechaAdquisicion] [datetime] NULL,
	[Acti_UsuarioCreacion] [int] NULL,
	[Acti_FechaCreacion] [datetime] NULL,
	[Acti_UsuarioModificacion] [int] NULL,
	[Acti_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Acti_Id] PRIMARY KEY CLUSTERED 
(
	[Acti_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acti].[tbActivosBitacora]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acti].[tbActivosBitacora](
	[ActB_Id] [int] IDENTITY(1,1) NOT NULL,
	[Acti_Id] [int] NULL,
	[Acti_Url] [varchar](90) NULL,
	[Acti_Descripcion] [varchar](30) NULL,
	[Acti_Precio] [numeric](8, 2) NULL,
	[Acti_Marca] [varchar](30) NULL,
	[Acti_Modelo] [varchar](30) NULL,
	[Acti_NoSerio] [varchar](20) NULL,
	[Empl_Id] [int] NULL,
	[VidU_Id] [int] NULL,
	[Acti_FechaAdquisicion] [datetime] NULL,
	[Acti_UsuarioCreacion] [int] NULL,
	[Acti_FechaCreacion] [datetime] NULL,
	[Acti_UsuarioModificacion] [int] NULL,
	[Acti_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_ActB_Id] PRIMARY KEY CLUSTERED 
(
	[ActB_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acti].[tbCategorias]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acti].[tbCategorias](
	[Cate_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cate_Descripcion] [varchar](30) NULL,
	[Cate_UsuarioCreacion] [int] NULL,
	[Cate_FechaCreacion] [datetime] NULL,
	[Cate_UsuarioModificacion] [int] NULL,
	[Cate_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Cate_Id] PRIMARY KEY CLUSTERED 
(
	[Cate_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Acti].[tbVidaUtil]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Acti].[tbVidaUtil](
	[VidU_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cate_Id] [int] NULL,
	[VidU_Descripcion] [varchar](30) NULL,
	[VidU_VidaEstimada] [numeric](8, 2) NULL,
	[VidU_UsuarioCreacion] [int] NULL,
	[VidU_FechaCreacion] [datetime] NULL,
	[VidU_UsuarioModificacion] [int] NULL,
	[VidU_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_VidU_Id] PRIMARY KEY CLUSTERED 
(
	[VidU_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gnrl].[tbCargos]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gnrl].[tbCargos](
	[Carg_Id] [int] IDENTITY(1,1) NOT NULL,
	[Carg_Descripcion] [varchar](30) NULL,
	[Carg_UsuarioCreacion] [int] NULL,
	[Carg_FechaCreacion] [datetime] NULL,
	[Carg_UsuarioModificacion] [int] NULL,
	[Carg_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Carg_Id] PRIMARY KEY CLUSTERED 
(
	[Carg_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gnrl].[tbDepartamentos]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gnrl].[tbDepartamentos](
	[Depa_Codigo] [varchar](2) NOT NULL,
	[Depa_Descripcion] [varchar](30) NOT NULL,
	[Depa_UsuarioCreacion] [int] NULL,
	[Depa_FechaCreacion] [datetime] NULL,
	[Depa_UsuarioModificacion] [int] NULL,
	[Depa_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Depa_Codigo] PRIMARY KEY CLUSTERED 
(
	[Depa_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gnrl].[tbEmpleados]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gnrl].[tbEmpleados](
	[Empl_Id] [int] IDENTITY(1,1) NOT NULL,
	[Empl_DNI] [varchar](8) NULL,
	[Empl_PNombre] [varchar](30) NULL,
	[Empl_SNombre] [varchar](30) NULL,
	[Empl_PApellido] [varchar](30) NULL,
	[Empl_SApellido] [varchar](30) NULL,
	[Empl_Sexo] [varchar](1) NULL,
	[EstD_Id] [int] NULL,
	[Depa_Codigo] [varchar](2) NULL,
	[Muni_Codigo] [varchar](4) NULL,
	[Empl_DireccionE] [varchar](30) NULL,
	[Empl_UsuarioCreacion] [int] NULL,
	[Empl_FechaCreacion] [datetime] NULL,
	[Empl_UsuarioModificacion] [int] NULL,
	[Empl_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Empl_Id] PRIMARY KEY CLUSTERED 
(
	[Empl_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gnrl].[tbEstadosCiviles]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gnrl].[tbEstadosCiviles](
	[EstD_Id] [int] NOT NULL,
	[EstD_Descripcion] [varchar](30) NOT NULL,
	[EstD_UsuarioCreacion] [int] NOT NULL,
	[EstD_FechaCracion] [datetime] NOT NULL,
	[EstD_UsuarioModificacion] [int] NULL,
	[EstD_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_EstD_Id] PRIMARY KEY CLUSTERED 
(
	[EstD_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gnrl].[tbMunicipios]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gnrl].[tbMunicipios](
	[Muni_Codigo] [varchar](4) NOT NULL,
	[Depa_Codigo] [varchar](2) NULL,
	[Muni_Descripcion] [varchar](40) NOT NULL,
	[Muni_UsuarioCreacion] [int] NULL,
	[Muni_FechaCreacion] [datetime] NULL,
	[Muni_UsuarioModificacion] [int] NULL,
	[Muni_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Muni_Codigo] PRIMARY KEY CLUSTERED 
(
	[Muni_Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Gnrl].[tbSucursales]    Script Date: 2/4/2024 15:03:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Gnrl].[tbSucursales](
	[Sucu_Id] [int] IDENTITY(1,1) NOT NULL,
	[Sucu_Descripcion] [varchar](30) NULL,
	[Depa_Codigo] [varchar](2) NULL,
	[Muni_Codigo] [varchar](4) NULL,
	[Sucu_DireccionExacta] [varchar](50) NULL,
	[Sucu_UsuarioCreacion] [int] NOT NULL,
	[Sucu_FechaCreacion] [datetime] NOT NULL,
	[Sucu_UsuarioModificacion] [int] NULL,
	[Sucu_FechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Sucu_Id] PRIMARY KEY CLUSTERED 
(
	[Sucu_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Acce].[tbUsuario] ON 

INSERT [Acce].[tbUsuario] ([Usua_Id], [Usua_Nombre], [Usua_Contra], [Usua_Admin], [Usua_Activo], [Usua_FechaCreacion], [Usua_FechaModificacion], [Usua_UsuarionCreacion], [Usua_UsuarionModificacion]) VALUES (1, N'admin', N'admin', 1, 1, CAST(N'2024-04-01T00:00:00.000' AS DateTime), CAST(N'2024-04-01T00:00:00.000' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [Acce].[tbUsuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbDepart__ED2DD75D320F9DF6]    Script Date: 2/4/2024 15:03:55 ******/
ALTER TABLE [Gnrl].[tbDepartamentos] ADD UNIQUE NONCLUSTERED 
(
	[Depa_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbEstado__DA9C1ADCE68E19D0]    Script Date: 2/4/2024 15:03:55 ******/
ALTER TABLE [Gnrl].[tbEstadosCiviles] ADD UNIQUE NONCLUSTERED 
(
	[EstD_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tbMunici__965316D6DC1E740C]    Script Date: 2/4/2024 15:03:55 ******/
ALTER TABLE [Gnrl].[tbMunicipios] ADD UNIQUE NONCLUSTERED 
(
	[Muni_Descripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Acce].[tbPantallasPorRoles]  WITH CHECK ADD  CONSTRAINT [FK_Pant_Id] FOREIGN KEY([Pant_Id])
REFERENCES [Acce].[tbPantallas] ([Pant_Id])
GO
ALTER TABLE [Acce].[tbPantallasPorRoles] CHECK CONSTRAINT [FK_Pant_Id]
GO
ALTER TABLE [Acce].[tbPantallasPorRoles]  WITH CHECK ADD  CONSTRAINT [FK_PaRo_PaRo_UsuarioModificacion] FOREIGN KEY([PaRo_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbPantallasPorRoles] CHECK CONSTRAINT [FK_PaRo_PaRo_UsuarioModificacion]
GO
ALTER TABLE [Acce].[tbPantallasPorRoles]  WITH CHECK ADD  CONSTRAINT [FK_PaRo_UsuarioCreacion] FOREIGN KEY([PaRo_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbPantallasPorRoles] CHECK CONSTRAINT [FK_PaRo_UsuarioCreacion]
GO
ALTER TABLE [Acce].[tbPantallasPorRoles]  WITH CHECK ADD  CONSTRAINT [FK_Role_Id] FOREIGN KEY([Role_Id])
REFERENCES [Acce].[tbRoles] ([Role_Id])
GO
ALTER TABLE [Acce].[tbPantallasPorRoles] CHECK CONSTRAINT [FK_Role_Id]
GO
ALTER TABLE [Acce].[tbRoles]  WITH CHECK ADD  CONSTRAINT [FK_Role_UsuarioCreacion] FOREIGN KEY([Role_UsuarionCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbRoles] CHECK CONSTRAINT [FK_Role_UsuarioCreacion]
GO
ALTER TABLE [Acce].[tbRoles]  WITH CHECK ADD  CONSTRAINT [FK_Role_UsuarioModificacion] FOREIGN KEY([Role_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbRoles] CHECK CONSTRAINT [FK_Role_UsuarioModificacion]
GO
ALTER TABLE [Acce].[tbUsuario]  WITH CHECK ADD  CONSTRAINT [FK_usuariocreacion_Id] FOREIGN KEY([Usua_UsuarionCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbUsuario] CHECK CONSTRAINT [FK_usuariocreacion_Id]
GO
ALTER TABLE [Acce].[tbUsuario]  WITH CHECK ADD  CONSTRAINT [FK_usuariomodificacion_Id] FOREIGN KEY([Usua_UsuarionModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acce].[tbUsuario] CHECK CONSTRAINT [FK_usuariomodificacion_Id]
GO
ALTER TABLE [Acti].[tbActivos]  WITH CHECK ADD  CONSTRAINT [FK_Acti_UsuarioCreacion] FOREIGN KEY([Acti_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acti].[tbActivos] CHECK CONSTRAINT [FK_Acti_UsuarioCreacion]
GO
ALTER TABLE [Acti].[tbActivos]  WITH CHECK ADD  CONSTRAINT [FK_Acti_UsuarioModificacion] FOREIGN KEY([Acti_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acti].[tbActivos] CHECK CONSTRAINT [FK_Acti_UsuarioModificacion]
GO
ALTER TABLE [Acti].[tbActivos]  WITH CHECK ADD  CONSTRAINT [FK_Empl_Id] FOREIGN KEY([Empl_Id])
REFERENCES [Gnrl].[tbEmpleados] ([Empl_Id])
GO
ALTER TABLE [Acti].[tbActivos] CHECK CONSTRAINT [FK_Empl_Id]
GO
ALTER TABLE [Acti].[tbActivos]  WITH CHECK ADD  CONSTRAINT [FK_VidU_Id] FOREIGN KEY([VidU_Id])
REFERENCES [Acti].[tbVidaUtil] ([VidU_Id])
GO
ALTER TABLE [Acti].[tbActivos] CHECK CONSTRAINT [FK_VidU_Id]
GO
ALTER TABLE [Acti].[tbCategorias]  WITH CHECK ADD  CONSTRAINT [FK_Cate_UsuarioCreacion] FOREIGN KEY([Cate_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acti].[tbCategorias] CHECK CONSTRAINT [FK_Cate_UsuarioCreacion]
GO
ALTER TABLE [Acti].[tbCategorias]  WITH CHECK ADD  CONSTRAINT [FK_Cate_UsuarioModificacion] FOREIGN KEY([Cate_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acti].[tbCategorias] CHECK CONSTRAINT [FK_Cate_UsuarioModificacion]
GO
ALTER TABLE [Acti].[tbVidaUtil]  WITH CHECK ADD  CONSTRAINT [FK_Cate_Id] FOREIGN KEY([Cate_Id])
REFERENCES [Acti].[tbCategorias] ([Cate_Id])
GO
ALTER TABLE [Acti].[tbVidaUtil] CHECK CONSTRAINT [FK_Cate_Id]
GO
ALTER TABLE [Acti].[tbVidaUtil]  WITH CHECK ADD  CONSTRAINT [FK_VidU_UsuarioCreacion] FOREIGN KEY([VidU_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acti].[tbVidaUtil] CHECK CONSTRAINT [FK_VidU_UsuarioCreacion]
GO
ALTER TABLE [Acti].[tbVidaUtil]  WITH CHECK ADD  CONSTRAINT [FK_VidU_UsuarioModificacion] FOREIGN KEY([VidU_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Acti].[tbVidaUtil] CHECK CONSTRAINT [FK_VidU_UsuarioModificacion]
GO
ALTER TABLE [Gnrl].[tbCargos]  WITH CHECK ADD  CONSTRAINT [FK_Carg_UsuarioCreacion] FOREIGN KEY([Carg_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbCargos] CHECK CONSTRAINT [FK_Carg_UsuarioCreacion]
GO
ALTER TABLE [Gnrl].[tbCargos]  WITH CHECK ADD  CONSTRAINT [FK_Carg_UsuarioModificacion] FOREIGN KEY([Carg_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbCargos] CHECK CONSTRAINT [FK_Carg_UsuarioModificacion]
GO
ALTER TABLE [Gnrl].[tbDepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_Depa_UsuarioCreacion] FOREIGN KEY([Depa_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbDepartamentos] CHECK CONSTRAINT [FK_Depa_UsuarioCreacion]
GO
ALTER TABLE [Gnrl].[tbDepartamentos]  WITH CHECK ADD  CONSTRAINT [FK_Depa_UsuarioModificacion] FOREIGN KEY([Depa_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbDepartamentos] CHECK CONSTRAINT [FK_Depa_UsuarioModificacion]
GO
ALTER TABLE [Gnrl].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_Depa_CodigoEM] FOREIGN KEY([Depa_Codigo])
REFERENCES [Gnrl].[tbDepartamentos] ([Depa_Codigo])
GO
ALTER TABLE [Gnrl].[tbEmpleados] CHECK CONSTRAINT [FK_Depa_CodigoEM]
GO
ALTER TABLE [Gnrl].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_Empl_UsuarioCreacion] FOREIGN KEY([Empl_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbEmpleados] CHECK CONSTRAINT [FK_Empl_UsuarioCreacion]
GO
ALTER TABLE [Gnrl].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_Empl_UsuarioModificacion] FOREIGN KEY([Empl_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbEmpleados] CHECK CONSTRAINT [FK_Empl_UsuarioModificacion]
GO
ALTER TABLE [Gnrl].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_EstD_Id] FOREIGN KEY([EstD_Id])
REFERENCES [Gnrl].[tbEstadosCiviles] ([EstD_Id])
GO
ALTER TABLE [Gnrl].[tbEmpleados] CHECK CONSTRAINT [FK_EstD_Id]
GO
ALTER TABLE [Gnrl].[tbEmpleados]  WITH CHECK ADD  CONSTRAINT [FK_Muni_CodigoEM] FOREIGN KEY([Muni_Codigo])
REFERENCES [Gnrl].[tbMunicipios] ([Muni_Codigo])
GO
ALTER TABLE [Gnrl].[tbEmpleados] CHECK CONSTRAINT [FK_Muni_CodigoEM]
GO
ALTER TABLE [Gnrl].[tbEstadosCiviles]  WITH CHECK ADD  CONSTRAINT [FK_EstD_UsuarioCreacion] FOREIGN KEY([EstD_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbEstadosCiviles] CHECK CONSTRAINT [FK_EstD_UsuarioCreacion]
GO
ALTER TABLE [Gnrl].[tbEstadosCiviles]  WITH CHECK ADD  CONSTRAINT [FK_EstD_UsuarioModificacion] FOREIGN KEY([EstD_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbEstadosCiviles] CHECK CONSTRAINT [FK_EstD_UsuarioModificacion]
GO
ALTER TABLE [Gnrl].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_Depa_Codigo] FOREIGN KEY([Depa_Codigo])
REFERENCES [Gnrl].[tbDepartamentos] ([Depa_Codigo])
GO
ALTER TABLE [Gnrl].[tbMunicipios] CHECK CONSTRAINT [FK_Depa_Codigo]
GO
ALTER TABLE [Gnrl].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_Muni_UsuarioCreacion] FOREIGN KEY([Muni_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbMunicipios] CHECK CONSTRAINT [FK_Muni_UsuarioCreacion]
GO
ALTER TABLE [Gnrl].[tbMunicipios]  WITH CHECK ADD  CONSTRAINT [FK_Muni_UsuarioModificacion] FOREIGN KEY([Muni_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbMunicipios] CHECK CONSTRAINT [FK_Muni_UsuarioModificacion]
GO
ALTER TABLE [Gnrl].[tbSucursales]  WITH CHECK ADD  CONSTRAINT [FK_Depa_Id] FOREIGN KEY([Depa_Codigo])
REFERENCES [Gnrl].[tbDepartamentos] ([Depa_Codigo])
GO
ALTER TABLE [Gnrl].[tbSucursales] CHECK CONSTRAINT [FK_Depa_Id]
GO
ALTER TABLE [Gnrl].[tbSucursales]  WITH CHECK ADD  CONSTRAINT [FK_Muni_Id] FOREIGN KEY([Muni_Codigo])
REFERENCES [Gnrl].[tbMunicipios] ([Muni_Codigo])
GO
ALTER TABLE [Gnrl].[tbSucursales] CHECK CONSTRAINT [FK_Muni_Id]
GO
ALTER TABLE [Gnrl].[tbSucursales]  WITH CHECK ADD  CONSTRAINT [FK_Sucu_UsuarioCreacion] FOREIGN KEY([Sucu_UsuarioCreacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbSucursales] CHECK CONSTRAINT [FK_Sucu_UsuarioCreacion]
GO
ALTER TABLE [Gnrl].[tbSucursales]  WITH CHECK ADD  CONSTRAINT [FK_Sucu_UsuarioModificacion] FOREIGN KEY([Sucu_UsuarioModificacion])
REFERENCES [Acce].[tbUsuario] ([Usua_Id])
GO
ALTER TABLE [Gnrl].[tbSucursales] CHECK CONSTRAINT [FK_Sucu_UsuarioModificacion]
GO
/****** Object:  StoredProcedure [dbo].[SP_Departamentos_Listado]    Script Date: 2/4/2024 15:03:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SP_Departamentos_Listado]
As
BEGIN 
	SELECT * FROM [Gnrl].[tbDepartamentos]
END
GO
