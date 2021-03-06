/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GlobalAccelerator.Model;

namespace Amazon.GlobalAccelerator
{
    /// <summary>
    /// Interface for accessing GlobalAccelerator
    ///
    /// AWS Global Accelerator 
    /// <para>
    /// This is the <i>AWS Global Accelerator API Reference</i>. This guide is for developers
    /// who need detailed information about AWS Global Accelerator API actions, data types,
    /// and errors. For more information about Global Accelerator features, see the <a href="https://docs.awa.amazon.com/global-accelerator/latest/dg/Welcome.html">AWS
    /// Global Accelerator Developer Guide</a>. 
    /// </para>
    ///  
    /// <para>
    /// AWS Global Accelerator is a network layer service in which you create accelerators
    /// to improve availability and performance for internet applications used by a global
    /// audience. 
    /// </para>
    ///  
    /// <para>
    /// Global Accelerator provides you with static IP addresses that you associate with your
    /// accelerator. These IP addresses are anycast from the AWS edge network and distribute
    /// incoming application traffic across multiple endpoint resources in multiple AWS Regions,
    /// which increases the availability of your applications. Endpoints can be Elastic IP
    /// addresses, Network Load Balancers, and Application Load Balancers that are located
    /// in one AWS Region or multiple Regions.
    /// </para>
    ///  
    /// <para>
    /// Global Accelerator uses the AWS global network to route traffic to the optimal regional
    /// endpoint based on health, client location, and policies that you configure. The service
    /// reacts instantly to changes in health or configuration to ensure that internet traffic
    /// from clients is directed to only healthy endpoints.
    /// </para>
    ///  
    /// <para>
    /// Global Accelerator includes components that work together to help you improve performance
    /// and availability for your applications:
    /// </para>
    ///  <dl> <dt>Static IP address</dt> <dd> 
    /// <para>
    /// AWS Global Accelerator provides you with a set of static IP addresses which are anycast
    /// from the AWS edge network and serve as the single fixed points of contact for your
    /// clients. If you already have Elastic Load Balancing or Elastic IP address resources
    /// set up for your applications, you can easily add those to Global Accelerator to allow
    /// the resources to be accessed by a Global Accelerator static IP address.
    /// </para>
    ///  </dd> <dt>Accelerator</dt> <dd> 
    /// <para>
    /// An accelerator directs traffic to optimal endpoints over the AWS global network to
    /// improve availability and performance for your internet applications that have a global
    /// audience. Each accelerator includes one or more listeners.
    /// </para>
    ///  </dd> <dt>Network zone</dt> <dd> 
    /// <para>
    /// A network zone services the static IP addresses for your accelerator from a unique
    /// IP subnet. Similar to an AWS Availability Zone, a network zone is an isolated unit
    /// with its own set of physical infrastructure. When you configure an accelerator, Global
    /// Accelerator allocates two IPv4 addresses for it. If one IP address from a network
    /// zone becomes unavailable due to IP address blocking by certain client networks, or
    /// network disruptions, then client applications can retry on the healthy static IP address
    /// from the other isolated network zone.
    /// </para>
    ///  </dd> <dt>Listener</dt> <dd> 
    /// <para>
    /// A listener processes inbound connections from clients to Global Accelerator, based
    /// on the protocol and port that you configure. Each listener has one or more endpoint
    /// groups associated with it, and traffic is forwarded to endpoints in one of the groups.
    /// You associate endpoint groups with listeners by specifying the Regions that you want
    /// to distribute traffic to. Traffic is distributed to optimal endpoints within the endpoint
    /// groups associated with a listener.
    /// </para>
    ///  </dd> <dt>Endpoint group</dt> <dd> 
    /// <para>
    /// Each endpoint group is associated with a specific AWS Region. Endpoint groups include
    /// one or more endpoints in the Region. You can increase or reduce the percentage of
    /// traffic that would be otherwise directed to an endpoint group by adjusting a setting
    /// called a traffic dial. The traffic dial lets you easily do performance testing or
    /// blue/green deployment testing for new releases across different AWS Regions, for example.
    /// 
    /// </para>
    ///  </dd> <dt>Endpoint</dt> <dd> 
    /// <para>
    /// An endpoint is an Elastic IP address, Network Load Balancer, or Application Load Balancer.
    /// Traffic is routed to endpoints based on several factors, including the geo-proximity
    /// to the user, the health of the endpoint, and the configuration options that you choose,
    /// such as endpoint weights. You can configure weights for each endpoint, which are numbers
    /// that you can use to specify the proportion of traffic to route to each one. This can
    /// be useful, for example, to do performance testing within a Region.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial interface IAmazonGlobalAccelerator : IAmazonService, IDisposable
    {
                
        #region  CreateAccelerator


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccelerator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateAccelerator">REST API Reference for CreateAccelerator Operation</seealso>
        Task<CreateAcceleratorResponse> CreateAcceleratorAsync(CreateAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEndpointGroup


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateEndpointGroup">REST API Reference for CreateEndpointGroup Operation</seealso>
        Task<CreateEndpointGroupResponse> CreateEndpointGroupAsync(CreateEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateListener


        /// <summary>
        /// Initiates the asynchronous execution of the CreateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateListener">REST API Reference for CreateListener Operation</seealso>
        Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccelerator


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccelerator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteAccelerator">REST API Reference for DeleteAccelerator Operation</seealso>
        Task<DeleteAcceleratorResponse> DeleteAcceleratorAsync(DeleteAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEndpointGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteEndpointGroup">REST API Reference for DeleteEndpointGroup Operation</seealso>
        Task<DeleteEndpointGroupResponse> DeleteEndpointGroupAsync(DeleteEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteListener


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccelerator


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAccelerator">REST API Reference for DescribeAccelerator Operation</seealso>
        Task<DescribeAcceleratorResponse> DescribeAcceleratorAsync(DescribeAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAcceleratorAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAcceleratorAttributes">REST API Reference for DescribeAcceleratorAttributes Operation</seealso>
        Task<DescribeAcceleratorAttributesResponse> DescribeAcceleratorAttributesAsync(DescribeAcceleratorAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpointGroup


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeEndpointGroup">REST API Reference for DescribeEndpointGroup Operation</seealso>
        Task<DescribeEndpointGroupResponse> DescribeEndpointGroupAsync(DescribeEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeListener


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeListener">REST API Reference for DescribeListener Operation</seealso>
        Task<DescribeListenerResponse> DescribeListenerAsync(DescribeListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccelerators


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccelerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccelerators operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListAccelerators">REST API Reference for ListAccelerators Operation</seealso>
        Task<ListAcceleratorsResponse> ListAcceleratorsAsync(ListAcceleratorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEndpointGroups


        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListEndpointGroups">REST API Reference for ListEndpointGroups Operation</seealso>
        Task<ListEndpointGroupsResponse> ListEndpointGroupsAsync(ListEndpointGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListListeners


        /// <summary>
        /// Initiates the asynchronous execution of the ListListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListListeners">REST API Reference for ListListeners Operation</seealso>
        Task<ListListenersResponse> ListListenersAsync(ListListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccelerator


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccelerator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAccelerator">REST API Reference for UpdateAccelerator Operation</seealso>
        Task<UpdateAcceleratorResponse> UpdateAcceleratorAsync(UpdateAcceleratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAcceleratorAttributes


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcceleratorAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAcceleratorAttributes">REST API Reference for UpdateAcceleratorAttributes Operation</seealso>
        Task<UpdateAcceleratorAttributesResponse> UpdateAcceleratorAttributesAsync(UpdateAcceleratorAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEndpointGroup


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateEndpointGroup">REST API Reference for UpdateEndpointGroup Operation</seealso>
        Task<UpdateEndpointGroupResponse> UpdateEndpointGroupAsync(UpdateEndpointGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateListener


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}