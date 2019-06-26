# AISnD
This is the repo of a project designing desktop application using C# based on WPF. The project is hold by AISnD, NCKU.

# Progress
## Week 1
- 初次登入設定_基本資料: `Login_BasicInfo`
- 初次登入設定_用餐人數: `Login_MealPeople`
    - 一間學校: `Login_SchoolTab`
        - 一個班級: `Login_SchoolTab_Class`

## Week 2
- 驗收詳情: `Backend_Acceptance`
    - 時間搜尋: `uc_Header` (by Yan Ci)
- 驗收詳情表單: `Backend_Acceptance_Detail`
- 圖片詳情: `Backend_Gallery`
    - 時間搜尋: `uc_Header` (by Yan Ci)

## Week 3
- 設定: `Setting`
    - 設定_基本資料: `Setting_BasicInfo`
    - 設定_供餐學校: `Setting_MealSchool`
        - 一間學校: `Setting_MealSchool_Section`
            - 學校名稱: `Setting_MealSchool_Entry_Location`
    - 設定_用餐人數_興隆國小: `Setting_MealPeople`
        - 學校人數設定: `Login_MealPeople` (Week 1)

## Weel 4
- 廚勤管理人員: `KitchenManagement`
    - 廚勤: `KitchenPeople`
        - 一位廚勤: `KitchenPeople_Entry`
    - 午秘: `LunchManager`
        - 一位午秘: `LunchManager_Entry`
    - 四張 icon 圖: `Pictures/`
        - `add` 
        - `duplicate`
        - `remove`
        - `edit`