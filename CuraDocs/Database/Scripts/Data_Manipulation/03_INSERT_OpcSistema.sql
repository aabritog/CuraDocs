USE [Curaduria]
GO

INSERT [dbo].[OpcSistema] ([nId], [nNotificacionMail], [sFromMail], [sCcMail], [sSubjectMail], [sBodyMail], [sUserNameCredentialsMail], [sPasswordCredentialsMail], [sHostMail], [nPortMail], [bEnableSsl]) VALUES (1, 1, N'ing.antonyab@gmail.com', N'', N'Notificacion de CuraDocs  Solicitud n°: txtNroRadicacion', N'Reciba un saludo cordial.NewLineNewLineCuraDocs le notifica que se han digitalizado imagenes para su evaluación.NewLineNewLineRadicación n°: txtNroRadicacion.NewLineNewLineNewLineEsta es una cuenta de correo no monitoreada, por favor no responder este correo electrónico.', N'ing.antonyab', N'anto.1907', N'smtp.gmail.com', 587, 1)
