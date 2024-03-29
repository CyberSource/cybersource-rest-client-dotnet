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
    ///  Class for testing EMVTagDetailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EMVTagDetailsApiTests
    {
        private EMVTagDetailsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EMVTagDetailsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EMVTagDetailsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EMVTagDetailsApi
            //Assert.IsInstanceOfType(typeof(EMVTagDetailsApi), instance, "instance is a EMVTagDetailsApi");
        }

        
        /// <summary>
        /// Test GetEmvTags
        /// </summary>
        [Test]
        public void GetEmvTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetEmvTags();
            //Assert.IsInstanceOf<TssV2GetEmvTags200Response> (response, "response is TssV2GetEmvTags200Response");
        }
        
        /// <summary>
        /// Test ParseEmvTags
        /// </summary>
        [Test]
        public void ParseEmvTagsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Body body = null;
            //var response = instance.ParseEmvTags(body);
            //Assert.IsInstanceOf<TssV2PostEmvTags200Response> (response, "response is TssV2PostEmvTags200Response");
        }
        
    }

}
