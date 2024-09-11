-- DROP SCHEMA dbo;

CREATE SCHEMA dbo;
-- fondoxyz.dbo.AspNetRoles definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.AspNetRoles;

CREATE TABLE fondoxyz.dbo.AspNetRoles (
	Id nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Name nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NormalizedName nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ConcurrencyStamp nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetRoles PRIMARY KEY (Id)
);
 CREATE  UNIQUE NONCLUSTERED INDEX RoleNameIndex ON dbo.AspNetRoles (  NormalizedName ASC  )  
	 WHERE  ([NormalizedName] IS NOT NULL)
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.AspNetUsers definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.AspNetUsers;

CREATE TABLE fondoxyz.dbo.AspNetUsers (
	Id nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	UserName nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NormalizedUserName nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	Email nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NormalizedEmail nvarchar(256) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	EmailConfirmed bit NOT NULL,
	PasswordHash nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	SecurityStamp nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ConcurrencyStamp nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PhoneNumber nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	PhoneNumberConfirmed bit NOT NULL,
	TwoFactorEnabled bit NOT NULL,
	LockoutEnd datetimeoffset NULL,
	LockoutEnabled bit NOT NULL,
	AccessFailedCount int NOT NULL,
	CONSTRAINT PK_AspNetUsers PRIMARY KEY (Id)
);
 CREATE NONCLUSTERED INDEX EmailIndex ON dbo.AspNetUsers (  NormalizedEmail ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
 CREATE  UNIQUE NONCLUSTERED INDEX UserNameIndex ON dbo.AspNetUsers (  NormalizedUserName ASC  )  
	 WHERE  ([NormalizedUserName] IS NOT NULL)
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.SedesRecreativas definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.SedesRecreativas;

CREATE TABLE fondoxyz.dbo.SedesRecreativas (
	Id int IDENTITY(1,1) NOT NULL,
	Nombre varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CapacidadTotal int NOT NULL,
	CONSTRAINT PK__SedesRec__3214EC07064E23B2 PRIMARY KEY (Id)
);


-- fondoxyz.dbo.Tarifas definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.Tarifas;

CREATE TABLE fondoxyz.dbo.Tarifas (
	Id int IDENTITY(1,1) NOT NULL,
	Temporada varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	TipoAlojamiento varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	TarifaPorNoche decimal(10,2) NOT NULL,
	CapacidadMaxima int NOT NULL,
	CONSTRAINT PK__Tarifas__3214EC0760F9C391 PRIMARY KEY (Id)
);


-- fondoxyz.dbo.Temporadas definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.Temporadas;

CREATE TABLE fondoxyz.dbo.Temporadas (
	Id int IDENTITY(1,1) NOT NULL,
	NombreTemporada varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FechaInicio date NOT NULL,
	FechaFin date NOT NULL,
	CONSTRAINT PK__Temporad__3214EC07BC8F6BEC PRIMARY KEY (Id)
);


-- fondoxyz.dbo.Usuarios definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.Usuarios;

CREATE TABLE fondoxyz.dbo.Usuarios (
	Id int IDENTITY(1,1) NOT NULL,
	NombreUsuario varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CorreoElectronico varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Password varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Rol nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK__Usuarios__3214EC076BB6D54D PRIMARY KEY (Id)
);


-- fondoxyz.dbo.[__EFMigrationsHistory] definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.[__EFMigrationsHistory];

CREATE TABLE fondoxyz.dbo.[__EFMigrationsHistory] (
	MigrationId nvarchar(150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ProductVersion nvarchar(32) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK___EFMigrationsHistory PRIMARY KEY (MigrationId)
);


-- fondoxyz.dbo.Apartamentos definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.Apartamentos;

CREATE TABLE fondoxyz.dbo.Apartamentos (
	Id int IDENTITY(1,1) NOT NULL,
	Nombre varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CapacidadMaxima int NOT NULL,
	SedeId int NOT NULL,
	CONSTRAINT PK__Apartame__3214EC07A5FE5BC2 PRIMARY KEY (Id),
	CONSTRAINT FK__Apartamen__SedeI__3A81B327 FOREIGN KEY (SedeId) REFERENCES fondoxyz.dbo.SedesRecreativas(Id)
);
 CREATE NONCLUSTERED INDEX IX_Apartamentos_SedeId ON dbo.Apartamentos (  SedeId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.AspNetRoleClaims definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.AspNetRoleClaims;

CREATE TABLE fondoxyz.dbo.AspNetRoleClaims (
	Id int IDENTITY(1,1) NOT NULL,
	RoleId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ClaimType nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ClaimValue nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetRoleClaims PRIMARY KEY (Id),
	CONSTRAINT FK_AspNetRoleClaims_AspNetRoles_RoleId FOREIGN KEY (RoleId) REFERENCES fondoxyz.dbo.AspNetRoles(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetRoleClaims_RoleId ON dbo.AspNetRoleClaims (  RoleId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.AspNetUserClaims definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.AspNetUserClaims;

CREATE TABLE fondoxyz.dbo.AspNetUserClaims (
	Id int IDENTITY(1,1) NOT NULL,
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ClaimType nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ClaimValue nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetUserClaims PRIMARY KEY (Id),
	CONSTRAINT FK_AspNetUserClaims_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES fondoxyz.dbo.AspNetUsers(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetUserClaims_UserId ON dbo.AspNetUserClaims (  UserId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.AspNetUserLogins definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.AspNetUserLogins;

CREATE TABLE fondoxyz.dbo.AspNetUserLogins (
	LoginProvider nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ProviderKey nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	ProviderDisplayName nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_AspNetUserLogins PRIMARY KEY (LoginProvider,ProviderKey),
	CONSTRAINT FK_AspNetUserLogins_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES fondoxyz.dbo.AspNetUsers(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetUserLogins_UserId ON dbo.AspNetUserLogins (  UserId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.AspNetUserRoles definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.AspNetUserRoles;

CREATE TABLE fondoxyz.dbo.AspNetUserRoles (
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	RoleId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	CONSTRAINT PK_AspNetUserRoles PRIMARY KEY (UserId,RoleId),
	CONSTRAINT FK_AspNetUserRoles_AspNetRoles_RoleId FOREIGN KEY (RoleId) REFERENCES fondoxyz.dbo.AspNetRoles(Id) ON DELETE CASCADE,
	CONSTRAINT FK_AspNetUserRoles_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES fondoxyz.dbo.AspNetUsers(Id) ON DELETE CASCADE
);
 CREATE NONCLUSTERED INDEX IX_AspNetUserRoles_RoleId ON dbo.AspNetUserRoles (  RoleId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.AspNetUserTokens definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.AspNetUserTokens;

CREATE TABLE fondoxyz.dbo.AspNetUserTokens (
	UserId nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	LoginProvider nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Name nvarchar(450) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	Value nvarchar(MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT PK_AspNetUserTokens PRIMARY KEY (UserId,LoginProvider,Name),
	CONSTRAINT FK_AspNetUserTokens_AspNetUsers_UserId FOREIGN KEY (UserId) REFERENCES fondoxyz.dbo.AspNetUsers(Id) ON DELETE CASCADE
);


-- fondoxyz.dbo.Habitaciones definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.Habitaciones;

CREATE TABLE fondoxyz.dbo.Habitaciones (
	Id int IDENTITY(1,1) NOT NULL,
	NumeroHabitacion varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	NumeroCamas int NOT NULL,
	CapacidadPersonas int NOT NULL,
	TipoHabitacion varchar(50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	ApartamentoId int NULL,
	CONSTRAINT PK__Habitaci__3214EC073E40CAEC PRIMARY KEY (Id),
	CONSTRAINT FK__Habitacio__Apart__3D5E1FD2 FOREIGN KEY (ApartamentoId) REFERENCES fondoxyz.dbo.Apartamentos(Id)
);
 CREATE NONCLUSTERED INDEX IX_Habitaciones_ApartamentoId ON dbo.Habitaciones (  ApartamentoId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;


-- fondoxyz.dbo.Reservas definition

-- Drop table

-- DROP TABLE fondoxyz.dbo.Reservas;

CREATE TABLE fondoxyz.dbo.Reservas (
	Id int IDENTITY(1,1) NOT NULL,
	UsuarioId int NOT NULL,
	ApartamentoId int NULL,
	FechaInicio date NOT NULL,
	FechaFin date NOT NULL,
	NumeroPersonas int NOT NULL,
	TotalReserva decimal(10,2) NOT NULL,
	CONSTRAINT PK__Reservas__3214EC07DFA653E8 PRIMARY KEY (Id),
	CONSTRAINT FK__Reservas__Aparta__4316F928 FOREIGN KEY (ApartamentoId) REFERENCES fondoxyz.dbo.Apartamentos(Id),
	CONSTRAINT FK__Reservas__Usuari__4222D4EF FOREIGN KEY (UsuarioId) REFERENCES fondoxyz.dbo.Usuarios(Id)
);
 CREATE NONCLUSTERED INDEX IX_Reservas_ApartamentoId ON dbo.Reservas (  ApartamentoId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;
 CREATE NONCLUSTERED INDEX IX_Reservas_UsuarioId ON dbo.Reservas (  UsuarioId ASC  )  
	 WITH (  PAD_INDEX = OFF ,FILLFACTOR = 100  ,SORT_IN_TEMPDB = OFF , IGNORE_DUP_KEY = OFF , STATISTICS_NORECOMPUTE = OFF , ONLINE = OFF , ALLOW_ROW_LOCKS = ON , ALLOW_PAGE_LOCKS = ON  )
	 ON [PRIMARY ] ;