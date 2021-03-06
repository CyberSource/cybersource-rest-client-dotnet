/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing TaxesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TaxesApiTests
    {
        private TaxesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TaxesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaxesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TaxesApi
            //Assert.IsInstanceOfType(typeof(TaxesApi), instance, "instance is a TaxesApi");
        }

        
        /// <summary>
        /// Test CalculateTax
        /// </summary>
        [Test]
        public void CalculateTaxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TaxRequest taxRequest = null;
            //var response = instance.CalculateTax(taxRequest);
            //Assert.IsInstanceOf<VasV2PaymentsPost201Response> (response, "response is VasV2PaymentsPost201Response");
        }
        
        /// <summary>
        /// Test VoidTax
        /// </summary>
        [Test]
        public void VoidTaxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VoidTaxRequest voidTaxRequest = null;
            //string id = null;
            //var response = instance.VoidTax(voidTaxRequest, id);
            //Assert.IsInstanceOf<VasV2TaxVoid200Response> (response, "response is VasV2TaxVoid200Response");
        }
        
    }

}
