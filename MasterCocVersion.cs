

/// <summary>
/// Master COC specifications
/// </summary>
public partial class MasterCocVersion
{
    /// <summary>
    /// Primary key. Foreign key to the MasterCoc table
    /// </summary>
    public int MasterCocId { get; set; }

    /// <summary>
    /// Primary key. MasterCoc Version id
    /// </summary>
    public int MasterCocVersionId { get; set; }

    /// <summary>
    /// Commercial name
    /// </summary>
    public string CommercialName { get; set; }

    /// <summary>
    /// Vehicle category. For 2 and 3 wheeled vehicles including the subcategory and subsubcategory
    /// </summary>
    public byte? VehicleCategoryId { get; set; }

    /// <summary>
    /// Manufacturer of the stage. Name of the manufacturer of the stage, for every entry in the COC for multistage vehicles
    /// </summary>
    public string ManufacturerName { get; set; }

    /// <summary>
    /// Manufacturer Address
    /// </summary>
    public string ManufacturerAddress { get; set; }

    /// <summary>
    /// Manufacturer Representative name and address
    /// </summary>
    public string ManufacturerRepresentative { get; set; }

    /// <summary>
    /// Manufacturer&apos;s plate (location)
    /// </summary>
    public string ManufacturerPlateLocation { get; set; }

    /// <summary>
    /// Manufacturer&apos;s plate (method of affixing)
    /// </summary>
    public string ManufacturerPlateMethodOfAffix { get; set; }

    /// <summary>
    /// Location of the statutory plates
    /// </summary>
    public byte? StatutoryPlatesLocationId { get; set; }

    /// <summary>
    /// Method of attachment of the statutory plates
    /// </summary>
    public byte? StatutoryPlatesAttachMethodId { get; set; }

    /// <summary>
    /// Location of the vehicle identification number
    /// </summary>
    public byte? VinLocationId { get; set; }

    /// <summary>
    /// Vin Location Description
    /// </summary>
    public string VinLocationDesc { get; set; }

    /// <summary>
    /// Number of axles
    /// </summary>
    public byte? NumberOfAxles { get; set; }

    /// <summary>
    /// Number of wheels
    /// </summary>
    public byte? NumberOfWheels { get; set; }

    /// <summary>
    /// Number of axles with twin wheels
    /// </summary>
    public byte? NumberOfAxlesWithTwinWheels { get; set; }

    /// <summary>
    /// Axles With Twin Wheels Position
    /// </summary>
    public string AxlesWithTwinWheelsPosition { get; set; }

    /// <summary>
    /// Number of Steered axles
    /// </summary>
    public byte? NumberOfSteeredAxles { get; set; }

    /// <summary>
    /// Steered Axles Position
    /// </summary>
    public string SteeredAxlesPosition { get; set; }

    /// <summary>
    /// Number of powered axles
    /// </summary>
    public byte? NumberOfPoweredAxles { get; set; }

    /// <summary>
    /// Powered Axles Position
    /// </summary>
    public string PoweredAxlesPosition { get; set; }

    /// <summary>
    /// Code to identify the type of advanced braking system
    /// </summary>
    public byte? AdvancedBrakingSystemId { get; set; }

    /// <summary>
    /// Advanced Braking System Description
    /// </summary>
    public string AdvancedBrakingSystemDesc { get; set; }

    /// <summary>
    /// Length. Unit: mm
    /// </summary>
    public int? Length { get; set; }

    /// <summary>
    /// Width. Unit: mm
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Height. Unit: mm
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// Wheelbase. Unit: mm
    /// </summary>
    public int? Wheelbase { get; set; }

    /// <summary>
    /// Fifth wheel lead for semi-trailer towing vehicle, or distance from vertical plane passing through the axis of the rear axle. Unit: mm
    /// </summary>
    public int? FifthWheelLead { get; set; }

    /// <summary>
    /// Distance between the front end of the vehicle and the centre of the coupling device. Unit: mm
    /// </summary>
    public int? DistFrontVehCentreCouplDev { get; set; }

    /// <summary>
    /// Distance between the centre of the coupling device and the rear end of the vehicle. Unit: mm
    /// </summary>
    public int? DistCentreCouplDevRearVeh { get; set; }

    /// <summary>
    /// Length of the loading area. Unit: mm
    /// </summary>
    public int? LengthOfTheLoadingArea { get; set; }

    /// <summary>
    /// Rear overhang. Unit: mm
    /// </summary>
    public int? RearOverhang { get; set; }

    /// <summary>
    /// Mass of the vehicle in running order. Unit: kg
    /// </summary>
    public int? MassOfTheVehicleInRunningOrder { get; set; }

    /// <summary>
    /// Actual mass of the vehicle. Unit: kg
    /// </summary>
    public int? ActualMassOfTheVehicle { get; set; }

    /// <summary>
    /// Unladen Mass of the vehicle. Unit: kg
    /// </summary>
    public int? UnladenMassOfTheVehicle { get; set; }

    /// <summary>
    /// Technically permissible maximum laden mass. Unit: kg
    /// </summary>
    public int? TechnPermMaxLadenMass { get; set; }

    /// <summary>
    /// Technically permissible maximum mass of the combination. Unit: kg
    /// </summary>
    public int? TechnPermMaxMassCombination { get; set; }

    /// <summary>
    /// Technically permissible maximum towable mass of Drawbar trailer. Excluding TechnPermMaxStatVertLoadCouplPt. Unit: kg
    /// </summary>
    public int? TechPermMaxTowMassDrawbarTrail { get; set; }

    /// <summary>
    /// Technically permissible maximum towable mass of Semi-trailer. Excluding TechnPermMaxStatVertLoadCouplPt. Unit: kg
    /// </summary>
    public int? TechPermMaxTowMassSemiTrailer { get; set; }

    /// <summary>
    /// Technically permissible maximum towable mass of Centre-axle trailer. Excluding TechnPermMaxStatVertLoadCouplPt. Unit: kg
    /// </summary>
    public int? TechPermMaxTowMassCentAxTrail { get; set; }

    /// <summary>
    /// Technically permissible maximum towable mass of Unbraked trailer. Excluding TechnPermMaxStatVertLoadCouplPt. Unit: kg
    /// </summary>
    public int? TechPermMaxTowMassUnbrTrailer { get; set; }

    /// <summary>
    /// Technically permissible maximum towable mass of Braked trailer. Excluding TechnPermMaxStatVertLoadCouplPt. Unit: kg
    /// </summary>
    public int? TechPermMaxTowMassBrakedTrail { get; set; }

    /// <summary>
    /// Technically permissible maximum static vertical mass at the coupling point. Unit: kg
    /// </summary>
    public int? TechPermMaxStatVertMassCouplPt { get; set; }

    /// <summary>
    /// Manufacturer of the engine
    /// </summary>
    public string EngineManufacturer { get; set; }

    /// <summary>
    /// The engine code is the code specifying the engine model as marked on the engine
    /// </summary>
    public string EngineCode { get; set; }

    /// <summary>
    /// Cycle four stroke/two stroke/Rotary or other
    /// </summary>
    public byte? EngineCycleId { get; set; }

    /// <summary>
    /// Engine Ignition
    /// </summary>
    public byte? EngineIgnitionId { get; set; }

    /// <summary>
    /// Working principle code
    /// </summary>
    public byte? WorkingPrincipleId { get; set; }

    /// <summary>
    /// Direct injection indicator
    /// </summary>
    public bool IsDirectInjection { get; set; }

    /// <summary>
    /// Pure electric indicator
    /// </summary>
    public bool IsPurelyElectric { get; set; }

    /// <summary>
    /// Hybrid indicator
    /// </summary>
    public bool IsHybrid { get; set; }

    /// <summary>
    /// Class of Hybrid [electric] vehicle
    /// </summary>
    public byte? HybridVehicleClassId { get; set; }

    /// <summary>
    /// Number of cylinders
    /// </summary>
    public byte? NumberOfCylinders { get; set; }

    /// <summary>
    /// Arrangement of cylinders
    /// </summary>
    public byte? CylindersArrangementId { get; set; }

    /// <summary>
    /// Engine capacity. Unit: cm^3
    /// </summary>
    public decimal? EngineCapacity { get; set; }

    /// <summary>
    /// Power Supply
    /// </summary>
    public byte? PowerSupplyId { get; set; }

    /// <summary>
    /// Fuel
    /// </summary>
    public byte? FuelId { get; set; }

    /// <summary>
    /// Fuel type
    /// </summary>
    public byte? FuelTypeId { get; set; }

    /// <summary>
    /// The normal operating mode of a dual-fuel engine during which the engine simultaneously uses diesel fuel and a gaseous fuel at some engine operating conditions
    /// </summary>
    public byte? DualFuelTypeId { get; set; }

    /// <summary>
    /// Electric vehicle configuration: pure electric/hybrid electric/manpower - electric
    /// </summary>
    public byte? ElectricVehicleConfigurationId { get; set; }

    /// <summary>
    /// The tank capacity in liters of the individual tank which is built-in in the vehicle.
    /// </summary>
    public decimal? FuelTankCapacity { get; set; }

    /// <summary>
    /// Maximum net power. Unit: kW
    /// </summary>
    public decimal? MaximumNetPower { get; set; }

    /// <summary>
    /// Maximum net power for electric engines. Unit: kW
    /// </summary>
    public decimal? MaximumNetPowerElectricEngine { get; set; }

    /// <summary>
    /// Engine speed maximum net power. Unit: 1/min
    /// </summary>
    public int? EngineSpeedMaximumNetPower { get; set; }

    /// <summary>
    /// Maximum speed. Unit: km/h
    /// </summary>
    public decimal? MaximumSpeed { get; set; }

    /// <summary>
    /// Power mass ratio of the vehicle in running order (kW/kg)
    /// </summary>
    public decimal? PowerMassRatio { get; set; }

    /// <summary>
    /// Gearbox (type)
    /// </summary>
    public byte? GearboxTypeId { get; set; }

    /// <summary>
    /// Gear ratio 1
    /// </summary>
    public decimal? GearRatio1 { get; set; }

    /// <summary>
    /// Gear ratio 2
    /// </summary>
    public decimal? GearRatio2 { get; set; }

    /// <summary>
    /// Gear ratio 3
    /// </summary>
    public decimal? GearRatio3 { get; set; }

    /// <summary>
    /// Gear ratio 4
    /// </summary>
    public decimal? GearRatio4 { get; set; }

    /// <summary>
    /// Gear ratio 5
    /// </summary>
    public decimal? GearRatio5 { get; set; }

    /// <summary>
    /// Gear ratio 6
    /// </summary>
    public decimal? GearRatio6 { get; set; }

    /// <summary>
    /// Gear ratio 7
    /// </summary>
    public decimal? GearRatio7 { get; set; }

    /// <summary>
    /// Gear ratio 8
    /// </summary>
    public decimal? GearRatio8 { get; set; }

    /// <summary>
    /// Final drive ratio
    /// </summary>
    public decimal? FinalDriveRatio { get; set; }

    /// <summary>
    /// Tires And Wheels
    /// </summary>
    public string TiresAndWheels { get; set; }

    /// <summary>
    /// Trailer brake connections mechanical/electric/pneumatic/hydraulic
    /// </summary>
    public byte? TrailerBrakeConnectTechId { get; set; }

    /// <summary>
    /// Pressure in feed line trailer braking system in kPa. Unit: kPa
    /// </summary>
    public decimal? PressFeedLineBraking { get; set; }

    /// <summary>
    /// Braking (brief description of the braking system)
    /// </summary>
    public string BrakingDesc { get; set; }

    /// <summary>
    /// Body Type
    /// </summary>
    public short? BodyTypeId { get; set; }

    /// <summary>
    /// Code for bodywork
    /// </summary>
    public byte? BodyworkTypeId { get; set; }

    /// <summary>
    /// Code for bodywork For special purpose vehicles: designation in accordance with Annex II of regulation 2007/46/EC
    /// </summary>
    public byte? BodyworkSpecialTypeId { get; set; }

    /// <summary>
    /// Number for bodywork
    /// </summary>
    public byte? BodyworkKindId { get; set; }

    /// <summary>
    /// Class of vehicle
    /// </summary>
    public byte? VehicleClassId { get; set; }

    /// <summary>
    /// Number of doors
    /// </summary>
    public byte? NumberOfDoors { get; set; }

    /// <summary>
    /// Configuration of doors
    /// Indicate the configuration by following codes:
    /// R = right side of the vehicle
    /// L = left side of the vehicle
    /// F = front side of the vehicle
    /// RE = rear side of the vehicle
    /// Example for a vehicle with 2 left side doors and 1 right door:
    /// 2L, 1R
    /// </summary>
    public string ConfigurationOfDoors { get; set; }

    /// <summary>
    /// Number of seating positions (including the driver)
    /// </summary>
    public short? NrOfSeatingPositions { get; set; }

    /// <summary>
    /// Number of seating positions (excluding the driver)
    /// </summary>
    public short? NrOfSeatingPositionExclDriver { get; set; }

    /// <summary>
    /// Positions of seats
    /// </summary>
    public string PositionOfSeats { get; set; }

    /// <summary>
    /// Seat(s) designated for use only when the vehicle is stationary
    /// </summary>
    public short? SeatForUseOnlyWhenTheVehStat { get; set; }

    /// <summary>
    /// Number of passenger seating positions - lower deck
    /// </summary>
    public short? NrOfPassSeatingPosLowerDeck { get; set; }

    /// <summary>
    /// Number of passenger seating positions - upper deck
    /// </summary>
    public short? NrOfPassSeatingPosUpperDeck { get; set; }

    /// <summary>
    /// Number of wheelchair user accessible position
    /// </summary>
    public short? NrOfWheelchairUserAccessPos { get; set; }

    /// <summary>
    /// Number of standing places
    /// </summary>
    public short? NumberOfStandingPlaces { get; set; }

    /// <summary>
    /// Approval number or approval mark of coupling device (if fitted) mechnical coupling type (s)
    /// </summary>
    public string ApprovalNrCouplingDevice { get; set; }

    /// <summary>
    /// Type approval mark mechanical coupling
    /// </summary>
    public string ApprovalMarkCouplingDevice { get; set; }

    /// <summary>
    /// Mechanical coupling characteristic D value. Unit: kN
    /// </summary>
    public decimal? CouplingCharacteristicValueD { get; set; }

    /// <summary>
    /// Mechanical coupling characteristic V value. Unit: kN
    /// </summary>
    public decimal? CouplingCharacteristicValueV { get; set; }

    /// <summary>
    /// Mechanical coupling characteristic S value. Unit: kg
    /// </summary>
    public int? CouplingCharacteristicValueS { get; set; }

    /// <summary>
    /// Mechanical coupling characteristic U value. Unit: kg
    /// </summary>
    public int? CouplingCharacteristicValueU { get; set; }

    /// <summary>
    /// Mechanical coupling characteristic DC value. Unit: kN
    /// </summary>
    public decimal? CouplingCharacteristicValueDc { get; set; }

    /// <summary>
    /// Exterior sound level number of the base regulatory act and latest amending regulatory act applicable, incl phase
    /// </summary>
    public string ExtSoundLevelNrBaseRegulAct { get; set; }

    /// <summary>
    /// Sound level Stationary. Unit: dB(A)
    /// </summary>
    public decimal? SoundLevelStationary { get; set; }

    /// <summary>
    /// Sound level Stationary engine speed. Unit: 1/min
    /// </summary>
    public int? SoundLevelStatEngineSpeed { get; set; }

    /// <summary>
    /// Sound level Drive-by. Unit: dB(A)
    /// </summary>
    public decimal? SoundLevelDriveBy { get; set; }

    /// <summary>
    /// Exhaust emission level Euro
    /// </summary>
    public byte? ExhaustEmissionLevelId { get; set; }

    /// <summary>
    /// Smoke corrected absorption coefficient. Unit: 1/m
    /// </summary>
    public decimal? SmokeCorrectedAbsorptionCoeff { get; set; }

    /// <summary>
    /// Other emission legislation
    /// </summary>
    public string Co2emissionsDescription { get; set; }

    /// <summary>
    /// Urban conditions CO2. Unit: g/km
    /// </summary>
    public short? UrbanConditionsCo2 { get; set; }

    /// <summary>
    /// Extra-urban conditions CO2. Unit: g/km
    /// </summary>
    public short? ExtraUrbanConditionsCo2 { get; set; }

    /// <summary>
    /// Combined CO2. Unit: g/km
    /// </summary>
    public short? CombinedCo2 { get; set; }

    /// <summary>
    /// All power trains, CO2 emissions of the WLTP combined testing phase. Unit: g/km
    /// </summary>
    public short? WltpcombinedCo2 { get; set; }

    /// <summary>
    /// Weighted, combined CO2. Unit: g/km
    /// </summary>
    public short? WeightedCombinedCo2 { get; set; }

    /// <summary>
    /// Urban conditions fuel consumption. 
    /// Depending on the fuel type a different Unit is applicable:
    /// Fuelcode Unit
    /// 10 - 13 Petrol l/100 km
    /// 15 - 18 Ethanol l/100 km
    /// 19 - Mixture l/100 km
    /// 20 - 26 Diesel l/100 km
    /// 30 - LPG l/100 km
    /// 40 - 43 CNG m^3/100 km
    /// 44 - Biomethane m^3/100 km
    /// 50 - Hydrogen kg/100 km
    /// 55 - H2NG m^3/100 km
    /// 60 - 63 LNG kg/100 km
    /// 72 - He-15 l/100 km
    /// 81 - 87 Diesel B5 - B50 l/100 km
    /// 90 - Other
    /// 91 - Compressed air
    /// </summary>
    public decimal? UrbanConditionsFuelConsumption { get; set; }

    /// <summary>
    /// Extra-urban conditions fuel consumption
    /// Depending on the fuel type a different unit is applicable:
    /// Fuelcode Unit
    /// 10 - 13 Petrol l/100 km
    /// 15 - 18 Ethanol l/100 km
    /// 19 - Mixture l/100 km
    /// 20 - 26 Diesel l/100 km
    /// 30 - LPG l/100 km
    /// 40 - 43 CNG m^3/100 km
    /// 44 - Biomethane m^3/100 km
    /// 50 - Hydrogen kg/100 km
    /// 55 - H2NG m^3/100 km
    /// 60 - 63 LNG kg/100 km
    /// 72 - He-15 l/100 km
    /// 81 - 87 Diesel B5 - B50 l/100 km
    /// 90 - Other
    /// 91 - Compressed air
    /// </summary>
    public decimal? ExtraUrbanConditionsFuelCons { get; set; }

    /// <summary>
    /// Combined fuel consumption
    /// Depending on the fuel type a different Unit is applicable:
    /// Fuelcode Unit
    /// 10 - 13 Petrol l/100 km
    /// 15 - 18 Ethanol l/100 km
    /// 19 - Mixture l/100 km
    /// 20 - 26 Diesel l/100 km
    /// 30 - LPG l/100 km
    /// 40 - 43 CNG m^3/100 km
    /// 44 - Biomethane m^3/100 km
    /// 50 - Hydrogen kg/100 km
    /// 55 - H2NG m^3/100 km
    /// 60 - 63 LNG kg/100 km
    /// 72 - He-15 l/100 km
    /// 81 - 87 Diesel B5 - B50 l/100 km
    /// 90 - Other
    /// 91 - Compressed air
    /// </summary>
    public decimal? CombinedFuelConsumption { get; set; }

    /// <summary>
    /// Weighted, combined fuel consumption
    /// Depending on the fuel type a different Unit is applicable:
    /// Fuelcode Unit
    /// 10 - 13 Petrol l/100 km
    /// 15 - 18 Ethanol l/100 km
    /// 19 - Mixture l/100 km
    /// 20 - 26 Diesel l/100 km
    /// 30 - LPG l/100 km
    /// 40 - 43 CNG m^3/100 km
    /// 44 - Biomethane m^3/100 km
    /// 50 - Hydrogen kg/100 km
    /// 55 - H2NG m^3/100 km
    /// 60 - 63 LNG kg/100 km
    /// 72 - He-15 l/100 km
    /// 81 - 87 Diesel B5 - B50 l/100 km
    /// 90 - Other 
    /// 91 - Compressed air
    /// </summary>
    public decimal? WeightedCombinedFuelCons { get; set; }

    /// <summary>
    /// Electric energy consumption weighted, combined. Unit: Wh/km
    /// </summary>
    public decimal? ElectricEnergyConsWeightedComb { get; set; }

    /// <summary>
    /// Electric range for pure electric vehicles. Unit: km
    /// </summary>
    public int? ElectricRange { get; set; }

    /// <summary>
    /// Electric energy consumption pure electric. Unit: Wh/km
    /// </summary>
    public decimal? ElectricEnergyConsPureElectric { get; set; }

    /// <summary>
    /// Type approved according to the design requirements for transporting dangerous goods indicator
    /// </summary>
    public bool IsTypeApprTranspDangerGoods { get; set; }

    /// <summary>
    /// Exemptions
    /// </summary>
    public string Exemptions { get; set; }

    /// <summary>
    /// Remarks
    /// </summary>
    public string Remarks { get; set; }

    /// <summary>
    /// Type Approval data in JSON format
    /// </summary>
    public string Tadata { get; set; }
}