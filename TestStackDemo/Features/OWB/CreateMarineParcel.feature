Feature: CreateMarineParcel
	In order to work with parcels
	As a OWB user
	I want to be able to create a parcel successfully

	Background: 
		Given I am logged in to OWB application
		And I am on the Shipments tab

	@OWB
	Scenario Outline: Ability to create a planned parcel
		Given I create New Planned Parcel with <TransportType> 
        And I fill in mandatory fields to create planned <ParcelType> with <Quantity> 
		When I create the parcel
		Then the parcel should be created successfully

		Examples:
		| ParcelType | Quantity | TransportType |
		| PURCHASE   | 100 BBL  | VESSEL        |
		| SALE       | 100 BBL  | BARGE         |
		| SALE       | 99.5 BBL | TANK          |
		| SALE       | 0.5 BBL  | TRAIN         |
		| STK FROM   | 100 BBL  | PUMPOVER      |
		| STK TO     | 100 BBL  | VESSEL        |