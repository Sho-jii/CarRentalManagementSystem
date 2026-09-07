CREATE TABLE [dbo].[CarRentalUsers] (
    [UserID]   INT          IDENTITY (1, 1) NOT NULL,
    [Username] NCHAR (15)   NOT NULL,
    [Password] NCHAR (15)   NOT NULL,
    [Status]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

SELECT * FROM CarRentalUsers

INSERT INTO CarRentalUsers (Username, Password, Status) VALUES ('Sho', '123', 'Active')

CREATE TABLE vehicleInventory (
VehicleID INT PRIMARY KEY IDENTITY(1,1),
Model VARCHAR(255) UNIQUE NOT NULL,
Registration VARCHAR(255) NOT NULL,
Status VARCHAR(255) NOT NULL,
YOM INT,
Color VARCHAR(255) NOT NULL,
Capacity INT,
FuelType VARCHAR(255) NOT NULL,
Transmission VARCHAR(255) NOT NULL,
DailyHirePrice DECIMAL(18,2),
Condition VARCHAR(255) NOT NULL,
DateAdded DATETIME 
);


INSERT INTO vehicleInventory
(Model, Registration, Status, YOM, Color, Capacity, FuelType, Transmission, DailyHirePrice, Condition, DateAdded)
VALUES 
('Mazda Cx7', 'KCS 300', 'In-Possession', 2012, 'White', 5, 'Petrol', 'Automatic', 30.00, 'Brand New', GETDATE());


SELECT * FROM vehicleInventory


CREATE TABLE clientProfiles (
ClientID INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(255),
Gender VARCHAR(255) NOT NULL,
Email VARCHAR(255),
Phone VARCHAR(255),
Address VARCHAR(255) NOT NULL,
Orders INT DEFAULT 0,
In_Possession INT DEFAULT 0,
Damaged INT DEFAULT 0,
Lost INT DEFAULT 0,
Spent DECIMAL(18,2) DEFAULT 0.00
);

INSERT INTO clientProfiles (Name, Gender, Email, Phone, Address, Orders, In_Possession, Damaged, Lost, Spent)
VALUES 
('John Doe', 'Male', 'johndoe@example.com', '09171234567', '123 Main St, Manila', 5, 1, 0, 0, 1500.00)

SELECT * FROM clientProfiles
DELETE FROM clientProfiles

CREATE TABLE vehicleRentals (
Id INT PRIMARY KEY IDENTITY(1,1),
VehicleID INT NOT NULL,
ClientID INT NOT NULL,
ConditionBefore VARCHAR(255) NOT NULL,
ConditionAfter VARCHAR(255) NOT NULL,
RentDate DATETIME,
Status VARCHAR(255),
ReturnDate DATETIME,
DailyHirePrice DECIMAL(18,2),
DateAdded DATETIME,
Days INT,
Total DECIMAL(18,2),
FOREIGN KEY (VehicleID) REFERENCES vehicleInventory (VehicleID),
FOREIGN KEY (ClientID) REFERENCES clientProfiles (ClientID)
); 


SELECT * FROM vehicleRentals


ALTER TABLE vehicleRentals
ADD VehicleModel VARCHAR(255),
    ClientName VARCHAR(255);

ALTER TABLE vehicleRentals 
ADD DamageFee DECIMAL(18, 2) DEFAULT 0.00

CREATE TABLE company (
CompanyID INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(255),
Email VARCHAR(255),
Phone VARCHAR(255),
Address VARCHAR(255) NOT NULL,
DateAdded DATETIME
);



SELECT 
            vi.VehicleID,
            vi.Model AS VehicleModel,
            SUM(vr.Total) AS TotalRevenue
        FROM 
            vehicleInventory AS vi
        LEFT JOIN 
            vehicleRentals AS vr ON vi.VehicleID = vr.VehicleID
        GROUP BY 
            vi.VehicleID, vi.Model
        ORDER BY 
            TotalRevenue DESC;

SELECT 
    vi.Model AS VehicleModel,
    CASE 
        WHEN vr.Status = 'In Possession' OR vr.ReturnDate IS NULL THEN 0
        ELSE SUM(vr.Total)
    END AS TotalRevenue
FROM 
    vehicleInventory AS vi
LEFT JOIN 
    vehicleRentals AS vr ON vi.VehicleID = vr.VehicleID
GROUP BY 
    vi.Model, vr.Status, vr.ReturnDate
ORDER BY 
    TotalRevenue DESC;

SELECT 
    Name AS ClientName,
    Spent AS TotalSpent
FROM 
    clientProfiles 
ORDER BY 
    Spent DESC;




SELECT 
                                vr.Id,
                                vr.RentDate,
                                vi.VehicleID,
                                cp.ClientID,
                                vr.VehicleModel,
                                vr.ClientName,
                                vr.ConditionBefore,
                                vr.ConditionAfter,
                                vr.Status,
                                vr.ReturnDate,
                                vr.DailyHirePrice,
                                CASE 
                                    WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0  
                                    WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN 1 
                                    ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) 
                                END AS Days,
                                CASE 
                                    WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0  
                                    WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN vr.DailyHirePrice  
                                    ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) * vr.DailyHirePrice  
                                END AS Total
                            FROM 
                                vehicleRentals AS vr
                            JOIN 
                                vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                            JOIN 
                                clientProfiles cp ON vr.ClientID = cp.ClientID
                            WHERE vi.Status = 'In-Possession'

SELECT 
    vr.Id,
    vr.RentDate,
    vr.VehicleID, 
    vr.ClientID, 
    vr.VehicleModel, 
    vr.ClientName, 
    vr.ConditionBefore,
    vr.ConditionAfter,
    vr.Status,
    vr.ReturnDate,
    vr.DailyHirePrice,
    CASE 
        WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN 1 
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) 
    END AS Days,
    CASE 
        WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) 
            THEN vr.DailyHirePrice  
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) * vr.DailyHirePrice 
    END AS Total
FROM 
    vehicleRentals AS vr
LEFT JOIN 
    vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
LEFT JOIN 
    clientProfiles AS cp ON vr.ClientID = cp.ClientID
WHERE 
    vr.Status = 'In-Possession'
    AND CAST(vr.RentDate AS DATE) <= CAST(GETDATE() AS DATE)
ORDER BY 
    vr.RentDate DESC;


SELECT 
                            vr.Id,
                            vr.RentDate,
                            vr.VehicleID, 
                            vr.ClientID, 
                            vr.VehicleModel, 
                            vr.ClientName, 
                            vr.ConditionBefore,
                            vr.ConditionAfter,
                            vr.Status,
                            vr.ReturnDate,
                            vr.DailyHirePrice,
                            CASE 
                                WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0  
                                WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN 1 
                                ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) 
                            END AS Days,
                            CASE 
                                WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) 
                                    THEN DATEDIFF(DAY, GETDATE(), vr.RentDate) * 100
                                ELSE 0
                            END AS FutureSurcharge,
                            CASE 
                                WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) 
                                    THEN DATEDIFF(DAY, GETDATE(), vr.RentDate) * 100 
                                WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) 
                                    THEN vr.DailyHirePrice  
                                ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) * vr.DailyHirePrice 
                            END AS Total
                        FROM 
                            vehicleRentals AS vr
                        LEFT JOIN 
                            vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                        LEFT JOIN 
                            clientProfiles AS cp ON vr.ClientID = cp.ClientID

SELECT 
    vr.Id,
    vr.RentDate,
    vr.VehicleID, 
    vr.ClientID, 
    vr.VehicleModel, 
    vr.ClientName, 
    vr.ConditionBefore,
    vr.ConditionAfter,
    vr.Status,
    vr.ReturnDate,
    vr.DailyHirePrice,
    -- Days calculation:
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0  -- Rent date is in the future, no days yet
        WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN 1  -- Rent date is today, count as 1 day
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1 -- +1 to count the same day rental
    END AS Days,
    -- Future surcharge calculation (200 per day until the rent date)
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200
        ELSE 0  -- No surcharge if the rent date is today or in the past
    END AS FutureSurcharge,
    -- Total calculation: DailyHirePrice * Days, plus surcharge for future days
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200  -- Surcharge only if the rent date is in the future
        WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN vr.DailyHirePrice  -- Today, so just the daily hire price
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1 * vr.DailyHirePrice  -- For past rentals, +1 to count the same day rental
    END AS Total
FROM 
    vehicleRentals AS vr
LEFT JOIN 
    vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
LEFT JOIN 
    clientProfiles AS cp ON vr.ClientID = cp.ClientID;





SELECT 
    vr.Id,
    vr.RentDate,
    vr.VehicleID, 
    vr.ClientID, 
    vr.VehicleModel, 
    vr.ClientName, 
    vr.ConditionBefore,
    vr.ConditionAfter,
    vr.Status,
    vr.ReturnDate,
    vr.DailyHirePrice,
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
        WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN 1
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1 
    END AS Days,
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
        WHEN CAST(vr.RentDate AS DATE) = CAST(GETDATE() AS DATE) THEN vr.DailyHirePrice
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1 * vr.DailyHirePrice
    END AS Total
FROM 
    vehicleRentals AS vr
LEFT JOIN 
    vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
LEFT JOIN 
    clientProfiles AS cp ON vr.ClientID = cp.ClientID
WHERE 
    vr.Status = 'In-Possession'
    AND CAST(vr.RentDate AS DATE) <= CAST(GETDATE() AS DATE)
ORDER BY 
    vr.RentDate DESC;


SELECT 
    c.Name AS ClientName,
    c.Gender,
    c.Address,
    c.Phone,
    c.Orders AS TotalRentedCars,
    c.Spent AS TotalSpent
FROM 
    vehicleRentals r
LEFT JOIN 
    clientProfiles c ON r.ClientID = c.ClientID
ORDER BY 
    c.Name ASC;

    SELECT 
                            c.Name AS ClientName,
                            c.Gender,
                            c.Address,
                            c.Phone,
                            c.Orders AS TotalRentedCars,
                            c.Spent AS TotalSpent
                            FROM 
                                clientProfiles c
                            LEFT JOIN 
                            clientProfiles r ON r.ClientID = c.ClientID
                            ORDER BY 
                                c.Spent DESC



SELECT 
                        vr.Id,
                        vr.RentDate,
                        vr.VehicleID, 
                        vr.ClientID, 
                        vi.Model AS VehicleModel, 
                        cp.Name AS ClientName, 
                        vr.ConditionBefore,
                        vr.ConditionAfter,
                        vr.Status,
                        vr.ReturnDate,
                        vr.DailyHirePrice,
                        CASE 
                            WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
                            ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1
                        END AS Days,
                        CASE 
                            WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) 
                                 THEN (DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200) 
                                      + ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                            WHEN CAST(vr.RentDate AS DATE) <= CAST(vr.DateAdded AS DATE) 
                                 THEN (DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice
                            ELSE 0
                        END AS Total,
                        vr.DateAdded
                    FROM 
                        vehicleRentals AS vr
                    LEFT JOIN 
                        vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                    LEFT JOIN 
                        clientProfiles AS cp ON vr.ClientID = cp.ClientID




SELECT 
    v.Model AS VehicleModel,
    v.[Condition] AS VehicleCondition,
    COUNT(r.Id) AS TimesRented,
    SUM(r.Days) AS TotalDaysRented,
    SUM(CASE 
            WHEN r.ReturnDate IS NOT NULL THEN r.Total 
            ELSE 0 
        END) AS TotalRevenue
FROM 
    vehicleInventory v
LEFT JOIN 
    vehicleRentals r ON v.VehicleID = r.VehicleID
GROUP BY 
    v.Model, v.[Condition]
ORDER BY 
    v.Model ASC;


    SELECT * FROM vehicleInventory WHERE Status = 'Available' AND Model LIKE 'M%' 
AND Transmission = 'Automatic';




SELECT 
                vr.Id,
                vr.RentDate,
                vr.VehicleID, 
                vr.ClientID, 
                vi.Model AS VehicleModel, 
                cp.Name AS ClientName, 
                vr.ConditionBefore,
                vr.ConditionAfter,
                vr.Status,
                vr.ReturnDate,
                vr.DailyHirePrice,
                CASE 
                    WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
                    ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1
                END AS Days,
                CASE 
                    WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) 
                         THEN (DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200) 
                              + ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                    WHEN CAST(vr.RentDate AS DATE) <= CAST(vr.DateAdded AS DATE) 
                         THEN (DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice
                    ELSE 0
                END AS Total,
                vr.DateAdded
                FROM 
                    vehicleRentals AS vr
                LEFT JOIN 
                    vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                LEFT JOIN 
                    clientProfiles AS cp ON vr.ClientID = cp.ClientID
                WHERE cp.Name LIKE 'J%' AND (CAST(vr.DateAdded AS DATE) = CAST(GETDATE() AS DATE)
                    OR CAST(vr.ReturnDate AS DATE) = CAST(GETDATE() AS DATE))
 
 

 SELECT 
    vr.Id,
    vr.RentDate,
    vr.VehicleID, 
    vr.ClientID, 
    vi.Model AS VehicleModel, 
    cp.Name AS ClientName, 
    vr.ConditionBefore,
    vr.ConditionAfter,
    vr.Status,
    vr.ReturnDate,
    vr.DailyHirePrice,
    -- Days rented or being rented
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1
    END AS Days,
    -- Total calculation
    CASE 
        -- Future RentDate: Add pre-rental charges (₱200/day for days between DateAdded and RentDate)
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 
            (DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200) 
        -- Active rental or past RentDate: Calculate rental charges + pre-rental charges if applicable
        ELSE 
            -- Active rental charges
            ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
            + 
            -- Pre-rental charges for days between DateAdded and RentDate (only if RentDate > DateAdded)
            CASE 
                WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) THEN 
                    DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200
                ELSE 0
            END
    END AS Total,
    vr.DateAdded
FROM 
    vehicleRentals AS vr
LEFT JOIN 
    vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
LEFT JOIN 
    clientProfiles AS cp ON vr.ClientID = cp.ClientID;


SELECT 
    vr.Id,
    vr.RentDate,
    vr.VehicleID, 
    vr.ClientID, 
    vi.Model AS VehicleModel, 
    cp.Name AS ClientName, 
    vr.ConditionBefore,
    vr.ConditionAfter,
    vr.Status,
    vr.ReturnDate,
    vr.DailyHirePrice,
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
        ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1
    END AS Days,
    CASE 
        WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 
            (DATEDIFF(DAY, GETDATE(), vr.RentDate) * 200) 
        ELSE 
            ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
            + 
            CASE 
                WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) THEN 
                    DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200
                ELSE 0
            END
    END AS Total,
    vr.DateAdded
FROM 
    vehicleRentals AS vr
LEFT JOIN 
    vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
LEFT JOIN 
    clientProfiles AS cp ON vr.ClientID = cp.ClientID;


