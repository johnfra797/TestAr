USE [ArandaTest]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 17/11/2019 9:00:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[IdPermiso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 17/11/2019 9:00:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IdRole] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[IdRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolePermiso]    Script Date: 17/11/2019 9:00:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolePermiso](
	[IdRolePermiso] [int] IDENTITY(1,1) NOT NULL,
	[CodRole] [int] NULL,
	[CodPermiso] [int] NULL,
 CONSTRAINT [PK_RolePermiso] PRIMARY KEY CLUSTERED 
(
	[IdRolePermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/11/2019 9:00:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Clave] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[CodRole] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (1, N'Leer')
INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (2, N'Consulta')
INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (4, N'Buscar')
INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (5, N'Comentar')
INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (6, N'Aprobar')
INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (7, N' Borrar Comentario')
INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (8, N'Crear Usuario')
INSERT [dbo].[Permiso] ([IdPermiso], [Nombre]) VALUES (9, N'Eliminar Usuario')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([IdRole], [Nombre]) VALUES (1, N'Visitante')
INSERT [dbo].[Role] ([IdRole], [Nombre]) VALUES (2, N'Consulta')
INSERT [dbo].[Role] ([IdRole], [Nombre]) VALUES (3, N'Usuario Autenticado')
INSERT [dbo].[Role] ([IdRole], [Nombre]) VALUES (4, N'Editor')
INSERT [dbo].[Role] ([IdRole], [Nombre]) VALUES (5, N'Administrador')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[RolePermiso] ON 

INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (1, 1, 1)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (2, 1, 4)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (3, 3, 1)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (4, 3, 4)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (5, 3, 5)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (6, 4, 1)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (7, 4, 4)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (8, 4, 6)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (9, 5, 1)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (10, 5, 4)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (11, 5, 7)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (12, 5, 8)
INSERT [dbo].[RolePermiso] ([IdRolePermiso], [CodRole], [CodPermiso]) VALUES (13, 5, 9)
SET IDENTITY_INSERT [dbo].[RolePermiso] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Direccion], [Telefono], [Email], [CodRole]) VALUES (2, N'Visitante', N'12345', N'Bogota', N'4514865', N'Visitante@Aranda.com', 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Direccion], [Telefono], [Email], [CodRole]) VALUES (5, N'Usuario Autenticado', N'12345', N'Barranquilla', N'4514865', N'UAutenticado@Aranda.com', 3)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Direccion], [Telefono], [Email], [CodRole]) VALUES (6, N'Editor', N'12345', N'Caracas', N'4514865', N'Editor@Aranda.com', 4)
INSERT [dbo].[Usuario] ([IdUsuario], [Nombre], [Clave], [Direccion], [Telefono], [Email], [CodRole]) VALUES (7, N'Administrador', N'12345', N'Maracaibo', N'4514865', N'Administrador@Aranda.com', 5)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[RolePermiso]  WITH CHECK ADD  CONSTRAINT [FK_RolePermiso_Permiso1] FOREIGN KEY([CodPermiso])
REFERENCES [dbo].[Permiso] ([IdPermiso])
GO
ALTER TABLE [dbo].[RolePermiso] CHECK CONSTRAINT [FK_RolePermiso_Permiso1]
GO
ALTER TABLE [dbo].[RolePermiso]  WITH CHECK ADD  CONSTRAINT [FK_RolePermiso_Role1] FOREIGN KEY([CodRole])
REFERENCES [dbo].[Role] ([IdRole])
GO
ALTER TABLE [dbo].[RolePermiso] CHECK CONSTRAINT [FK_RolePermiso_Role1]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Role] FOREIGN KEY([CodRole])
REFERENCES [dbo].[Role] ([IdRole])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Role]
GO
