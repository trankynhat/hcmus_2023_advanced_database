-- TREATMENT_PLAN_STATUS
GO
USE CQ_CSDLNC_05
GO

SET IDENTITY_INSERT treatment_plan_status ON 
GO
INSERT treatment_plan_status (id, name, [desc], symbolic_color) VALUES (0, N'Đã lên kế hoạch', N'Đã lên kế hoạch', N'#0010D0')
GO
INSERT treatment_plan_status (id, name, [desc], symbolic_color) VALUES (1, N'Đã hoàn thành', N'Đã hoàn thành', N'#04BF23')
GO
INSERT treatment_plan_status (id, name, [desc], symbolic_color) VALUES (2, N'Đã hủy', N'Đã hủy', N'#B6CC00')
GO
SET IDENTITY_INSERT treatment_plan_status OFF
GO
