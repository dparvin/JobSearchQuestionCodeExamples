# API Connector

## Problem
How can an external web application securely communicate with
an on-premises installation located behind a customer's firewall?

## Constraints
- Customer controls the firewall.
- No inbound ports should be opened.
- Multiple customers.
- Secure communications.
- Near real-time responses.

## Purpose
Designed and implemented the official reference implementation
demonstrating how third-party developers can securely integrate
cloud-hosted web applications with on-premises Denali accounting
systems.

The project accompanies the Denali API documentation and serves as
sample code for customers and integration partners.

## Architecture
The solution uses a cloud-hosted middleware service that maintains a
persistent SignalR connection with a Windows Service running inside the
customer's network.

Since the connection is initiated from inside the customer's firewall,
no inbound firewall ports need to be opened. External web applications
communicate with the middleware, which relays requests to the
on-premises service over the existing secure connection.

This architecture supports multiple customer installations while
keeping internal systems isolated from direct Internet access.

## Design Decisions
SignalR was selected because it provides a persistent, bidirectional
connection between the middleware and the on-premises Windows Service.

This allows requests from external systems to be forwarded without
requiring inbound firewall rules or polling.

## Technologies
- C#
- SignalR
- Azure VM
- Azure App Service
- HTTPS
- SSL Certificates
- Windows Service
- REST
- JSON
- SQL Server
- API Documentation
- SDK Documentation
- Developer Documentation

## Deliverables
- Denali API reference implementation
- Middleware Windows Service
- Azure-hosted middleware
- SignalR communication layer
- Sample web application
- Developer documentation
- Source code for customers and partners

## My Role
- Designed the overall communication architecture.
- Developed the Windows Service connector.
- Implemented SignalR communication.
- Configured Azure VM deployment.
- Configured HTTPS and SSL/TLS certificates for secure communication 
between Azure-hosted components.
- Integrated with the Denali API.
- Tested communication across customer environments.

## Challenges
- Firewall traversal
- Certificate configuration
- Reliable persistent connections

## Interview Questions This Project Can Answer
- Tell me about a difficult project.
- Describe a distributed system you designed.
- Have you worked with Azure?
- Have you used SignalR?
- How have you integrated cloud and on-premises systems?
- Tell me about a networking challenge you solved.

## Things an Interviewer Might Ask
- Why SignalR instead of polling?
- Why not expose a REST API directly?
- How did you authenticate the Windows Service?
- What happened if the connection was lost?
- How did you support multiple customers?
- How was logging handled?
- How was the system monitored?

## Lessons Learned
- Design around network topology.
- Secure communication is often harder than business logic.
- Deployment is as important as development.

## Looking Back

If I were implementing this today, I would also evaluate:

- Azure SignalR Service
- Azure Service Bus
- gRPC
- Container-based deployment
- Managed identities for authentication

The original architecture met the requirements and was appropriate
for the technologies available at the time.

## Resources
- [Denali API Demo Connector Source Code](https://service.cougarmtn.com/APIfiles/Denali%20API%20Demo%20Connector%20Source%20Code.zip)
- [Denali API Documentation](https://service.cougarmtn.com/APIfiles/html/8aad8d85-990e-4a1d-8f56-9e50d78ad3f4.htm)

**Category:** 

System Design

**Difficulty:** 

Intermediate

**Last Reviewed:** 

2026-07-21
