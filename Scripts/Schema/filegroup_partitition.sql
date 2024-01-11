-- Thêm filegroup
USE CQ_CSDLNC_05

CREATE PARTITION FUNCTION pf_payment__date_of_payment (DATETIME)
AS
RANGE LEFT
FOR VALUES ( '2023-01-01', '2025-01-01', '2027-01-01')
GO

CREATE PARTITION SCHEME pf_payment__date_of_payment__scheme
AS PARTITION pf_payment__date_of_payment
TO ([PRIMARY], CQ_CSDLNC_05_FG1, CQ_CSDLNC_05_FG2, CQ_CSDLNC_05_FG3)


CREATE PARTITION FUNCTION pf_treatment__treatment_date (DATETIME)
AS
RANGE RIGHT
FOR VALUES ( '2023-01-01', '2025-01-01', '2027-01-01')
GO


CREATE PARTITION SCHEME pf_treatment__treatment_date__scheme
AS PARTITION pf_treatment__treatment_date
TO ([PRIMARY], CQ_CSDLNC_05_FG1, CQ_CSDLNC_05_FG2, CQ_CSDLNC_05_FG3)


CREATE PARTITION FUNCTION pf_single_treatment__treatment_id (INT)
AS
RANGE RIGHT
FOR VALUES (100000, 200000, 300000)
GO

CREATE PARTITION SCHEME pf_single_treatment__treatment_id__scheme
AS PARTITION pf_single_treatment__treatment_id
TO ([PRIMARY], CQ_CSDLNC_05_FG1, CQ_CSDLNC_05_FG2, CQ_CSDLNC_05_FG3)

CREATE PARTITION FUNCTION pf_treatment_phase__treatment_id (INT)
AS
RANGE RIGHT
FOR VALUES (100000, 200000, 300000)
GO

CREATE PARTITION SCHEME pf_treatment_phase__treatment_id__scheme
AS PARTITION pf_treatment_phase__treatment_id
TO ([PRIMARY], CQ_CSDLNC_05_FG1, CQ_CSDLNC_05_FG2, CQ_CSDLNC_05_FG3)

CREATE PARTITION FUNCTION pf_appointment_schedule__appointment_date (DATETIME)
AS
RANGE RIGHT
FOR VALUES ( '2023-01-01', '2025-01-01', '2027-01-01')
GO

CREATE PARTITION SCHEME pf_appointment_schedule__appointment_date__scheme
AS PARTITION pf_appointment_schedule__appointment_date
TO ([PRIMARY], CQ_CSDLNC_05_FG1, CQ_CSDLNC_05_FG2, CQ_CSDLNC_05_FG3)