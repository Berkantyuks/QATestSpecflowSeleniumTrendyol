﻿Feature: Product

A short summary of the feature

@Smoke @ProductSeller
Scenario: Visitor should be able see product seller
	Given Navigate to trendyol website
	And Search for product "İpad Mini" in search
	And Verify search executed
	When Click first product in results
	And Verify product detail page opened
	And Get product seller name
	And Click product seller page link
	And Verify seller page opened
	Then Verify the product seller with received name

@Smoke @MultipleProduct
Scenario Outline: Visitor should be able add multiple products to cart
	Given Navigate to trendyol website
	And Search for product "<SearchQuery>" in search
	And Verify search executed
	When Click first product in results
	And Verify product detail page opened
	And Get Product base link
	And Click add to cart button
	And Click see cart button
	And Verify cart page opened
	And Click "<ButtonType>" Button for "<ClickTimes>" times


Examples: 
	| SearchQuery  | ButtonType | ClickTimes |
	| Kurşun Kalem | Plus       | 4          |