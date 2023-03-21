alter table tbl_Phongban


GO
alter proc [dbo].[sp_ThemPhongBan] (@PK_sMaPB varchar(30),    @sTenPB varchar(10),  @sMota varchar(10),)
as
begin
insert into tbl_Phongban (PK_sMaPB,sTenPB,sMota,sNoidung)
	values (@PK_sMaPB, @sTenPB )
end

alter PROCEDURE sp_SuaPhongBan
 @PK_sMaPB varchar(30), @sTenPB varchar(10),  @sMota varchar(10), 
as
BEGIN
	 UPDATE tbl_PhongBan
	 SET 
	  sTenPB= @sTenPB,sMota=@sMota
	 Where PK_sMaPB = @PK_sMaPB
end

create PROCEDURE [dbo].[sp_XoaPhongBan]
@PK_sMaPB VARCHAR(10)
AS 
	BEGIN
	DELETE tbl_PhongBan WHERE PK_sMaPB = @PK_sMaPB
	END

GO
