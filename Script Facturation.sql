USE [Facturation]
GO
/****** Object:  Table [dbo].[Agent]    Script Date: 9/3/2018 1:23:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agent](
	[Code_agent] [int] NOT NULL,
	[nom_agent] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_agent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 9/3/2018 1:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Code_cl] [int] NOT NULL,
	[nom_cl] [varchar](25) NULL,
	[adress] [varchar](50) NULL,
	[ville] [varchar](50) NULL,
	[solde] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_cl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Conserner]    Script Date: 9/3/2018 1:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Conserner](
	[montant_reg] [money] NULL,
	[no_facture] [int] NULL,
	[no_reglement] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contient]    Script Date: 9/3/2018 1:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contient](
	[qut_cd] [int] NULL,
	[ref] [varchar](50) NULL,
	[no_facture] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[en_mode]    Script Date: 9/3/2018 1:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[en_mode](
	[sous_montant] [float] NULL,
	[no_reglement] [int] NULL,
	[code_mode] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facture]    Script Date: 9/3/2018 1:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facture](
	[no_facture] [int] NOT NULL,
	[date_facture] [date] NULL,
	[moantant_facture] [money] NULL,
	[montant_reste] [money] NULL,
	[code_cl] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[no_facture] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marchandise]    Script Date: 9/3/2018 1:23:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marchandise](
	[ref] [varchar](50) NOT NULL,
	[designation] [varchar](50) NULL,
	[pu] [float] NULL,
	[qut_st] [int] NULL,
 CONSTRAINT [PK_marchandise] PRIMARY KEY CLUSTERED 
(
	[ref] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mode]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mode](
	[Code_mode] [int] NOT NULL,
	[libelle_mode] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code_mode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reglement]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reglement](
	[no_reglement] [int] NOT NULL,
	[date_reg] [date] NULL,
	[total_reglement] [float] NULL,
	[code_agent] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[no_reglement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[ID] [varchar](50) NOT NULL,
	[PSW] [varchar](50) NULL,
	[USERNAME] [varchar](50) NULL,
	[STATUT] [bit] NULL,
	[DATE_DRN_VALIDER] [date] NULL,
	[NOMBRE_TENTATIVE] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Client] ([Code_cl], [nom_cl], [adress], [ville], [solde]) VALUES (1, N'Mojahid BELAMAN', N'hay dakhla blok G', N'Boujniba', 35900.0000)
INSERT [dbo].[Client] ([Code_cl], [nom_cl], [adress], [ville], [solde]) VALUES (2, N'Othman FADIL', N'Hay Dakhla Bloc B', N'khouribga', 50000.0000)
INSERT [dbo].[Client] ([Code_cl], [nom_cl], [adress], [ville], [solde]) VALUES (3, N'Kamal EZIKOURI', N'hay dakhla bloc F', N'khouribga', 70000.0000)
INSERT [dbo].[Client] ([Code_cl], [nom_cl], [adress], [ville], [solde]) VALUES (4, N'Ayoub ElBEZDAWI', N'tachroun', N'boujniba', 98000.0000)
INSERT [dbo].[Contient] ([qut_cd], [ref], [no_facture]) VALUES (2, N'art4', 1)
INSERT [dbo].[Contient] ([qut_cd], [ref], [no_facture]) VALUES (2, N'art1', 2)
INSERT [dbo].[Contient] ([qut_cd], [ref], [no_facture]) VALUES (3, N'art1', 3)
INSERT [dbo].[Contient] ([qut_cd], [ref], [no_facture]) VALUES (1, N'art5', 4)
INSERT [dbo].[Contient] ([qut_cd], [ref], [no_facture]) VALUES (1, N'art4', 5)
INSERT [dbo].[Contient] ([qut_cd], [ref], [no_facture]) VALUES (1, N'art2', 5)
INSERT [dbo].[Facture] ([no_facture], [date_facture], [moantant_facture], [montant_reste], [code_cl]) VALUES (1, CAST(N'2017-04-02' AS Date), 200.0000, 39800.0000, 1)
INSERT [dbo].[Facture] ([no_facture], [date_facture], [moantant_facture], [montant_reste], [code_cl]) VALUES (2, CAST(N'2017-05-26' AS Date), 2000.0000, 98000.0000, 4)
INSERT [dbo].[Facture] ([no_facture], [date_facture], [moantant_facture], [montant_reste], [code_cl]) VALUES (3, CAST(N'2017-06-05' AS Date), 3000.0000, 36800.0000, 1)
INSERT [dbo].[Facture] ([no_facture], [date_facture], [moantant_facture], [montant_reste], [code_cl]) VALUES (4, CAST(N'2017-10-13' AS Date), 300.0000, 36500.0000, 1)
INSERT [dbo].[Facture] ([no_facture], [date_facture], [moantant_facture], [montant_reste], [code_cl]) VALUES (5, CAST(N'2017-10-13' AS Date), 600.0000, 35900.0000, 1)
INSERT [dbo].[marchandise] ([ref], [designation], [pu], [qut_st]) VALUES (N'art1', N'laptop', 1000, 1)
INSERT [dbo].[marchandise] ([ref], [designation], [pu], [qut_st]) VALUES (N'art2', N'caméra', 500, 2)
INSERT [dbo].[marchandise] ([ref], [designation], [pu], [qut_st]) VALUES (N'art3', N'lenovo B590', 1500, 3)
INSERT [dbo].[marchandise] ([ref], [designation], [pu], [qut_st]) VALUES (N'art4', N'USB', 100, 17)
INSERT [dbo].[marchandise] ([ref], [designation], [pu], [qut_st]) VALUES (N'art5', N'Lecteur DVD', 300, 29)
INSERT [dbo].[marchandise] ([ref], [designation], [pu], [qut_st]) VALUES (N'art6', N'Lecteur CD', 200, 15)
INSERT [dbo].[marchandise] ([ref], [designation], [pu], [qut_st]) VALUES (N'art7', N'Carte mére', 5000, 4)
INSERT [dbo].[Mode] ([Code_mode], [libelle_mode]) VALUES (1, N'chèque')
INSERT [dbo].[Mode] ([Code_mode], [libelle_mode]) VALUES (2, N'espèce')
INSERT [dbo].[Mode] ([Code_mode], [libelle_mode]) VALUES (3, N'carte de crédit')
INSERT [dbo].[Utilisateur] ([ID], [PSW], [USERNAME], [STATUT], [DATE_DRN_VALIDER], [NOMBRE_TENTATIVE]) VALUES (N'admin', N'ad123', N'Mojahid BELAMAN', 1, CAST(N'2018-09-03' AS Date), 0)
INSERT [dbo].[Utilisateur] ([ID], [PSW], [USERNAME], [STATUT], [DATE_DRN_VALIDER], [NOMBRE_TENTATIVE]) VALUES (N'user', N'us123', N'Ayoub TALABI', 1, CAST(N'2017-04-05' AS Date), 4)
ALTER TABLE [dbo].[Conserner]  WITH CHECK ADD  CONSTRAINT [FK_Conserner_Facture] FOREIGN KEY([no_facture])
REFERENCES [dbo].[Facture] ([no_facture])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Conserner] CHECK CONSTRAINT [FK_Conserner_Facture]
GO
ALTER TABLE [dbo].[Conserner]  WITH CHECK ADD  CONSTRAINT [FK_Conserner_Reglement] FOREIGN KEY([no_reglement])
REFERENCES [dbo].[Reglement] ([no_reglement])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Conserner] CHECK CONSTRAINT [FK_Conserner_Reglement]
GO
ALTER TABLE [dbo].[Contient]  WITH CHECK ADD  CONSTRAINT [FK_Contient_Facture] FOREIGN KEY([no_facture])
REFERENCES [dbo].[Facture] ([no_facture])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contient] CHECK CONSTRAINT [FK_Contient_Facture]
GO
ALTER TABLE [dbo].[Contient]  WITH CHECK ADD  CONSTRAINT [FK_Contient_marchandise] FOREIGN KEY([ref])
REFERENCES [dbo].[marchandise] ([ref])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Contient] CHECK CONSTRAINT [FK_Contient_marchandise]
GO
ALTER TABLE [dbo].[en_mode]  WITH CHECK ADD  CONSTRAINT [FK_en_mode_Mode] FOREIGN KEY([code_mode])
REFERENCES [dbo].[Mode] ([Code_mode])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[en_mode] CHECK CONSTRAINT [FK_en_mode_Mode]
GO
ALTER TABLE [dbo].[en_mode]  WITH CHECK ADD  CONSTRAINT [FK_en_mode_Reglement] FOREIGN KEY([no_reglement])
REFERENCES [dbo].[Reglement] ([no_reglement])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[en_mode] CHECK CONSTRAINT [FK_en_mode_Reglement]
GO
ALTER TABLE [dbo].[Facture]  WITH CHECK ADD  CONSTRAINT [FK_Facture_Client] FOREIGN KEY([code_cl])
REFERENCES [dbo].[Client] ([Code_cl])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Facture] CHECK CONSTRAINT [FK_Facture_Client]
GO
ALTER TABLE [dbo].[Reglement]  WITH CHECK ADD  CONSTRAINT [FK_Reglement_Agent] FOREIGN KEY([code_agent])
REFERENCES [dbo].[Agent] ([Code_agent])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reglement] CHECK CONSTRAINT [FK_Reglement_Agent]
GO
/****** Object:  StoredProcedure [dbo].[ADD_ARTICLE]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_ARTICLE]
@REF VARCHAR(50), @DESIGNATION VARCHAR(50), @PU FLOAT, @QUT_ST INT
AS
INSERT INTO [dbo].[marchandise]
           ([ref]
		   ,[designation]
           ,[pu]
           ,[qut_st])
     VALUES
           (@REF
		   ,@designation
           ,@pu
           ,@qut_st)
GO
/****** Object:  StoredProcedure [dbo].[ADD_CLIENT]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_CLIENT]
@CODE_CL INT, @NOM_CL VARCHAR(25), @ADRESSE VARCHAR(50), @VILLE VARCHAR(50), @SOLDE MONEY
AS
INSERT INTO [dbo].[Client]
           ([Code_cl]
           ,[nom_cl]
           ,[adress]
           ,[ville]
           ,[solde])
     VALUES
           (@CODE_CL
           ,@NOM_CL
           ,@ADRESSE
           ,@VILLE
           ,@SOLDE)
GO
/****** Object:  StoredProcedure [dbo].[ADD_CONTIENT]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_CONTIENT]
@REF VARCHAR(50), @NO_FACTURE INT, @QUT_CD INT
AS
INSERT INTO [dbo].[Contient]
           ([qut_cd]
           ,[ref]
		   ,[no_facture])
     VALUES
           (@QUT_CD
		   ,@REF
           ,@NO_FACTURE)

UPDATE marchandise SET qut_st = qut_st - @QUT_CD WHERE ref = @REF

GO
/****** Object:  StoredProcedure [dbo].[ADD_FACTURE]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ADD_FACTURE]
@NO_FACTURE INT, @DATE_FACTURE DATE, @MONTANT_FACTURE MONEY, @MONTANT_RESTE MONEY, @CODE_CL INT
AS
INSERT INTO [dbo].[Facture]
           ([no_facture]
           ,[date_facture]
           ,[moantant_facture]
           ,[montant_reste]
           ,[code_cl])
     VALUES
           (@NO_FACTURE
           ,@DATE_FACTURE
           ,@MONTANT_FACTURE
		   ,@MONTANT_RESTE
           ,@CODE_CL)

UPDATE Client SET solde = solde - @MONTANT_FACTURE WHERE Code_cl = @CODE_CL

GO
/****** Object:  StoredProcedure [dbo].[ALL_ARTICLE]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ALL_ARTICLE]
AS 
SELECT ref, designation, pu, qut_st FROM marchandise 
GO
/****** Object:  StoredProcedure [dbo].[ALL_CLIENT]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ALL_CLIENT]
AS
SELECT Code_cl AS 'Code Client' , nom_cl AS 'Nom Client', solde AS 'Solde' FROM Client
GO
/****** Object:  StoredProcedure [dbo].[LAST_FACTURE]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LAST_FACTURE]
AS
SELECT ISNULL(MAX(no_facture) + 1, 1) FROM Facture
GO
/****** Object:  StoredProcedure [dbo].[LAST_FACTURE_PRINT]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LAST_FACTURE_PRINT]
AS
SELECT MAX(no_facture) FROM Facture
GO
/****** Object:  StoredProcedure [dbo].[PRINT_DETAIL_FACTURE]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PRINT_DETAIL_FACTURE]
@NO_FACTURE INT
AS
SELECT F.[no_facture]
      ,F.[date_facture]
      ,F.[moantant_facture]
      ,F.[montant_reste]
      ,F.[code_cl]
	  ,CL.nom_cl
	  ,CL.adress
	  ,CL.ville
	  ,CL.solde
	  ,M.ref
	  ,M.designation
	  ,M.pu
	  ,M.qut_st
	  ,C.qut_cd
  FROM Facture F
  INNER JOIN Contient C ON C.no_facture = F.no_facture
  INNER JOIN marchandise M ON C.ref = M.ref
  INNER JOIN Client CL ON F.code_cl = CL.Code_cl
  WHERE F.no_facture = @NO_FACTURE
GO
/****** Object:  StoredProcedure [dbo].[PRINT_DETAIL_FACTURE2]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PRINT_DETAIL_FACTURE2]
AS
SELECT F.[no_facture]
      ,F.[date_facture]
      ,F.[moantant_facture]
      ,F.[montant_reste]
      ,F.[code_cl]
	  ,CL.nom_cl
	  ,CL.adress
	  ,CL.ville
	  ,CL.solde
  FROM Facture F
  INNER JOIN Client CL on F.code_cl = CL.Code_cl
GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_LOGIN] 
	@ID varchar(50), @PSW varchar(50) 
as

--Si la connexion est OK
IF (SELECT COUNT(*) FROM Utilisateur WHERE ID = @ID AND PSW = @PSW AND statut = 1) = 1
	BEGIN
		UPDATE Utilisateur SET NOMBRE_TENTATIVE = 0, DATE_DRN_VALIDER = GETDATE() WHERE ID = @ID AND PSW = @PSW
		return 0
	end
ELSE
	BEGIN
		-- Si le compte utilisateur n'existe pas
		if((select count(*) from Utilisateur where ID = @ID and PSW = @PSW) = 0)
			begin 
				return 1
			end
		ELSE
			BEGIN
				--Si le compte est bloqué (statut = 0)
				if((select STATUT from Utilisateur where ID = @ID) = 0)
					begin
						return 2
					end
				ELSE
					BEGIN
						--Si le mot de passe fourni n'est pas correcte
						if((select PSW from Utilisateur where ID = @ID) <> @PSW)
							begin
								BEGIN TRAN
									UPDATE Utilisateur SET NOMBRE_TENTATIVE = NOMBRE_TENTATIVE + 1 WHERE ID = @ID
									IF(SELECT NOMBRE_TENTATIVE FROM Utilisateur WHERE ID = @ID) > 3
									BEGIN
										UPDATE Utilisateur SET STATUT = 0 WHERE ID = @ID
									END
								COMMIT TRAN
								return 3
							end
					END
			END
	END
GO
/****** Object:  StoredProcedure [dbo].[VERIFIER_ID]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VERIFIER_ID]
	@REF VARCHAR(50)
AS
SELECT * FROM marchandise WHERE ref = @REF
GO
/****** Object:  StoredProcedure [dbo].[VERIFIER_ID_CLIENT]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VERIFIER_ID_CLIENT]
	@CODE_CL INT
AS
SELECT * FROM Client WHERE Code_cl = @CODE_CL
GO
/****** Object:  StoredProcedure [dbo].[VERIFY_QUTESTOCK]    Script Date: 9/3/2018 1:23:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VERIFY_QUTESTOCK]
	@REF VARCHAR(6), @QUT_ST INT
AS
SELECT * FROM marchandise WHERE ref = @REF AND qut_st > @QUT_ST
GO
