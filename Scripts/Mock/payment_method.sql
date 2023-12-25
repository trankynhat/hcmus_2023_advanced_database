-- PAYMENT_METHOD
GO
USE CQ_CSDLNC_05
GO

INSERT payment_method (code, name, [desc]) VALUES (N'direct', N'Tiền mặt', N'Tiền mặt')
GO
INSERT payment_method (code, name, [desc]) VALUES (N'online', N'Thanh toán online', N'Thanh toán online')
GO
