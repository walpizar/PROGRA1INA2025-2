CREATE TABLE [tb_Modulo] (
    [id_modulo] int NOT NULL IDENTITY,
    [nombre_modulo] nvarchar(100) NOT NULL,
    [descripcion_modulo] nvarchar(200) NULL,
    CONSTRAINT [PK_tb_Modulo] PRIMARY KEY ([id_modulo])
);
GO


CREATE TABLE [tbCategoriaActivos] (
    [Id] int NOT NULL IDENTITY,
    [nombre] nvarchar(50) NOT NULL,
    [descripcion] nvarchar(200) NOT NULL,
    [estado] bit NOT NULL,
    CONSTRAINT [PK_tbCategoriaActivos] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [tbDepartamento] (
    [idDepartamento] int NOT NULL IDENTITY,
    [nombreDepartamento] nvarchar(100) NOT NULL,
    [descripcion] nvarchar(200) NOT NULL,
    [estado] bit NOT NULL,
    [usuarioCreacion] nvarchar(max) NOT NULL,
    [fechaCreacion] datetime2 NOT NULL,
    [usuarioModificacion] nvarchar(max) NOT NULL,
    [fechaModificacion] datetime2 NULL,
    CONSTRAINT [PK_tbDepartamento] PRIMARY KEY ([idDepartamento])
);
GO


CREATE TABLE [tbEspecialidadMedica] (
    [idEspecialidadMedica] int NOT NULL,
    [nombreEspecialidad] nvarchar(100) NOT NULL,
    [descripcion] nvarchar(200) NOT NULL,
    [estado] bit NOT NULL,
    CONSTRAINT [PK_tbEspecialidadMedica] PRIMARY KEY ([idEspecialidadMedica])
);
GO


CREATE TABLE [tbPersonas] (
    [id] nvarchar(20) NOT NULL,
    [tipoId] int NOT NULL,
    [nombre] nvarchar(50) NOT NULL,
    [apellido1] nvarchar(50) NOT NULL,
    [apellido2] nvarchar(50) NOT NULL,
    [fechaNac] datetime2 NOT NULL,
    [email] nvarchar(100) NOT NULL,
    [direccion] nvarchar(200) NOT NULL,
    [telefono] nvarchar(20) NOT NULL,
    [estado] bit NOT NULL,
    CONSTRAINT [PK_tbPersonas] PRIMARY KEY ([id], [tipoId])
);
GO


CREATE TABLE [tbPuestos] (
    [idPuesto] int NOT NULL IDENTITY,
    [nombrePuesto] nvarchar(100) NOT NULL,
    [descripcion] nvarchar(200) NOT NULL,
    [estado] bit NOT NULL,
    CONSTRAINT [PK_tbPuestos] PRIMARY KEY ([idPuesto])
);
GO


CREATE TABLE [tbRoles] (
    [idRol] int NOT NULL IDENTITY,
    [nombreRol] nvarchar(100) NOT NULL,
    [descripcion] nvarchar(200) NOT NULL,
    [estado] bit NOT NULL,
    CONSTRAINT [PK_tbRoles] PRIMARY KEY ([idRol])
);
GO


CREATE TABLE [tbPermisos] (
    [idPermiso] int NOT NULL IDENTITY,
    [nombrePermiso] nvarchar(100) NOT NULL,
    [descripcion] nvarchar(200) NOT NULL,
    [estado] bit NOT NULL,
    [clsModuloid_modulo] int NULL,
    CONSTRAINT [PK_tbPermisos] PRIMARY KEY ([idPermiso]),
    CONSTRAINT [FK_tbPermisos_tb_Modulo_clsModuloid_modulo] FOREIGN KEY ([clsModuloid_modulo]) REFERENCES [tb_Modulo] ([id_modulo])
);
GO


CREATE TABLE [tbActivos] (
    [idActivo] int NOT NULL IDENTITY,
    [nombreActivo] nvarchar(100) NOT NULL,
    [descripcion] nvarchar(200) NOT NULL,
    [estado] bit NOT NULL,
    [estadoUso] int NOT NULL,
    [fechaAdquisicion] date NOT NULL,
    [proveedor] nvarchar(100) NOT NULL,
    [ubicacion] nvarchar(100) NOT NULL,
    [fechaCreacion] datetime NOT NULL,
    [usuarioCreacion] nvarchar(50) NOT NULL,
    [fechaModificacion] datetime NULL,
    [usuarioModificacion] nvarchar(50) NOT NULL,
    [idCategoria] int NOT NULL,
    [fechaDesecho] date NULL,
    [observacionDesecho] nvarchar(200) NOT NULL,
    CONSTRAINT [PK_tbActivos] PRIMARY KEY ([idActivo]),
    CONSTRAINT [FK_tbActivos_tbCategoriaActivos_idCategoria] FOREIGN KEY ([idCategoria]) REFERENCES [tbCategoriaActivos] ([Id]) ON DELETE NO ACTION
);
GO


CREATE TABLE [tbDonantes] (
    [personaId] nvarchar(20) NOT NULL,
    [personaTipoId] int NOT NULL,
    [idDonante] int NOT NULL IDENTITY,
    [estado] bit NOT NULL,
    [fechaRegistro] datetime2 NOT NULL,
    CONSTRAINT [PK_tbDonantes] PRIMARY KEY ([personaId], [personaTipoId]),
    CONSTRAINT [FK_tbDonantes_tbPersonas_personaId_personaTipoId] FOREIGN KEY ([personaId], [personaTipoId]) REFERENCES [tbPersonas] ([id], [tipoId]) ON DELETE NO ACTION
);
GO


CREATE TABLE [tbEnfermeros] (
    [id] nvarchar(20) NOT NULL,
    [tipoId] int NOT NULL,
    [area] nvarchar(300) NOT NULL,
    [numeroColegiado] nvarchar(20) NOT NULL,
    [fechaCrea] datetime2 NOT NULL,
    [usuarioCrea] nvarchar(100) NOT NULL,
    [fechaUltMod] datetime2 NOT NULL,
    [usuarioUltMod] nvarchar(100) NOT NULL,
    [estado] bit NOT NULL,
    CONSTRAINT [PK_tbEnfermeros] PRIMARY KEY ([id], [tipoId]),
    CONSTRAINT [FK_tbEnfermeros_tbPersonas_id_tipoId] FOREIGN KEY ([id], [tipoId]) REFERENCES [tbPersonas] ([id], [tipoId]) ON DELETE CASCADE
);
GO


CREATE TABLE [tbMedico] (
    [id] nvarchar(20) NOT NULL,
    [tipoId] int NOT NULL,
    [especialidad] nvarchar(300) NOT NULL,
    [fechaCrea] datetime2 NOT NULL,
    [usuarioCrea] nvarchar(100) NOT NULL,
    [fechaUltMod] datetime2 NOT NULL,
    [usuarioUltMod] nvarchar(100) NOT NULL,
    [estado] bit NOT NULL,
    [idPersona] int NOT NULL,
    CONSTRAINT [PK_tbMedico] PRIMARY KEY ([id], [tipoId]),
    CONSTRAINT [FK_tbMedico_tbPersonas_id_tipoId] FOREIGN KEY ([id], [tipoId]) REFERENCES [tbPersonas] ([id], [tipoId]) ON DELETE NO ACTION
);
GO


CREATE TABLE [tbUsuarios] (
    [usuarioId] int NOT NULL IDENTITY,
    [personaId] nvarchar(20) NOT NULL,
    [personaTipoId] int NOT NULL,
    [nombre_usuario] nvarchar(50) NOT NULL,
    [contrasena] nvarchar(100) NOT NULL,
    [email] nvarchar(100) NOT NULL,
    [estado] bit NOT NULL,
    CONSTRAINT [PK_tbUsuarios] PRIMARY KEY ([usuarioId]),
    CONSTRAINT [FK_tbUsuarios_tbPersonas_personaId_personaTipoId] FOREIGN KEY ([personaId], [personaTipoId]) REFERENCES [tbPersonas] ([id], [tipoId]) ON DELETE CASCADE
);
GO


CREATE TABLE [tbRolPermiso] (
    [idRol] int NOT NULL,
    [idPermiso] int NOT NULL,
    [estado] bit NOT NULL,
    [RolidRol] int NOT NULL,
    [PermisoidPermiso] int NOT NULL,
    CONSTRAINT [PK_tbRolPermiso] PRIMARY KEY ([idRol], [idPermiso]),
    CONSTRAINT [FK_tbRolPermiso_tbPermisos_PermisoidPermiso] FOREIGN KEY ([PermisoidPermiso]) REFERENCES [tbPermisos] ([idPermiso]) ON DELETE CASCADE,
    CONSTRAINT [FK_tbRolPermiso_tbRoles_RolidRol] FOREIGN KEY ([RolidRol]) REFERENCES [tbRoles] ([idRol]) ON DELETE CASCADE
);
GO


CREATE TABLE [tbDevolucion] (
    [idDevolucion] int NOT NULL IDENTITY,
    [fechaDevolucion] date NOT NULL,
    [observaciones] nvarchar(200) NOT NULL,
    [idActivoFK] int NOT NULL,
    CONSTRAINT [PK_tbDevolucion] PRIMARY KEY ([idDevolucion]),
    CONSTRAINT [FK_tbDevolucion_tbActivos_idActivoFK] FOREIGN KEY ([idActivoFK]) REFERENCES [tbActivos] ([idActivo]) ON DELETE CASCADE
);
GO


CREATE TABLE [tbDonaciones] (
    [idDonacion] int NOT NULL IDENTITY,
    [fechaDonacion] datetime2 NOT NULL,
    [tipoDonacion] int NOT NULL,
    [observaciones] nvarchar(max) NOT NULL,
    [donantepersonaId] nvarchar(20) NOT NULL,
    [donantepersonaTipoId] int NOT NULL,
    CONSTRAINT [PK_tbDonaciones] PRIMARY KEY ([idDonacion]),
    CONSTRAINT [FK_tbDonaciones_tbDonantes_donantepersonaId_donantepersonaTipoId] FOREIGN KEY ([donantepersonaId], [donantepersonaTipoId]) REFERENCES [tbDonantes] ([personaId], [personaTipoId]) ON DELETE CASCADE
);
GO


CREATE TABLE [tbDonacionesActivos] (
    [idDonacionActivo] int NOT NULL IDENTITY,
    [idDonacion] int NOT NULL,
    [idActivo] int NOT NULL,
    [cantidad] int NOT NULL,
    [estadoActivo] nvarchar(30) NOT NULL,
    [observaciones] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_tbDonacionesActivos] PRIMARY KEY ([idDonacionActivo]),
    CONSTRAINT [FK_tbDonacionesActivos_tbActivos_idActivo] FOREIGN KEY ([idActivo]) REFERENCES [tbActivos] ([idActivo]) ON DELETE CASCADE,
    CONSTRAINT [FK_tbDonacionesActivos_tbDonaciones_idDonacion] FOREIGN KEY ([idDonacion]) REFERENCES [tbDonaciones] ([idDonacion]) ON DELETE CASCADE
);
GO


CREATE TABLE [tbDonacionesDinero] (
    [idDonacionDinero] int NOT NULL IDENTITY,
    [idDonacion] int NOT NULL,
    [monto] decimal(18,2) NOT NULL,
    [tipoTransaccion] int NOT NULL,
    [frecuencia] int NOT NULL,
    [moneda] nvarchar(5) NOT NULL,
    [descripcion] nvarchar(100) NOT NULL,
    CONSTRAINT [PK_tbDonacionesDinero] PRIMARY KEY ([idDonacionDinero]),
    CONSTRAINT [FK_tbDonacionesDinero_tbDonaciones_idDonacion] FOREIGN KEY ([idDonacion]) REFERENCES [tbDonaciones] ([idDonacion]) ON DELETE CASCADE
);
GO


CREATE INDEX [IX_tbActivos_idCategoria] ON [tbActivos] ([idCategoria]);
GO


CREATE INDEX [IX_tbDevolucion_idActivoFK] ON [tbDevolucion] ([idActivoFK]);
GO


CREATE INDEX [IX_tbDonaciones_donantepersonaId_donantepersonaTipoId] ON [tbDonaciones] ([donantepersonaId], [donantepersonaTipoId]);
GO


CREATE INDEX [IX_tbDonacionesActivos_idActivo] ON [tbDonacionesActivos] ([idActivo]);
GO


CREATE INDEX [IX_tbDonacionesActivos_idDonacion] ON [tbDonacionesActivos] ([idDonacion]);
GO


CREATE UNIQUE INDEX [IX_tbDonacionesDinero_idDonacion] ON [tbDonacionesDinero] ([idDonacion]);
GO


CREATE INDEX [IX_tbPermisos_clsModuloid_modulo] ON [tbPermisos] ([clsModuloid_modulo]);
GO


CREATE INDEX [IX_tbRolPermiso_PermisoidPermiso] ON [tbRolPermiso] ([PermisoidPermiso]);
GO


CREATE INDEX [IX_tbRolPermiso_RolidRol] ON [tbRolPermiso] ([RolidRol]);
GO


CREATE INDEX [IX_tbUsuarios_personaId_personaTipoId] ON [tbUsuarios] ([personaId], [personaTipoId]);
GO


