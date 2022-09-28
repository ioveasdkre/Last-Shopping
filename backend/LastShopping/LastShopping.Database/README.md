# 資料庫說明
	LastShoppingDb：網站資訊管理資料庫
	UserAppDb：身分權限資料庫

## 新增資料庫異動訊息
	add-migration 訊息 -context LastShoppingDbContext -OutputDir Migrations/LastShoppingDb
	add-migration 訊息 -context UserAppDbContext -OutputDir Migrations/UserAppDb

### 更新資料庫
	Update-Database -context LastShoppingDbContext
	Update-Database -context UserAppDbContext