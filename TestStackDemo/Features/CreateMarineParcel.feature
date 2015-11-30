Feature: CreateMarineParcel
	In order to work with parcels
	As a OWB user
	I want to be able to create a parcel successfully

	Background: 
		Given I am logged in to OWB application
		And I am on the Shipments tab

	Scenario Outline: Ability to create a planned parcel
		Given I have filled in the mandatory fields to create a planned <ParcelType> with <Quantity> 
		When I create the parcel
		Then the parcel should be created successfully

		Examples:
		| ParcelType | Quantity |
		| Purchase   | 100 BBL  |
		| Sale       | 100 BBL  |
		| Sale       | 99.5 BBL |
		| Sale       | 0.5 BBL  |
		| Stock From | 100 BBL  |
		| Stock To   | 100 BBL  |