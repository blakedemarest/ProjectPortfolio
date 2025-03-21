# System Proposal Draft - Cowboy Hotel Conference Room Booking System

**ISDS-406: Systems Analysis & Design -- Project Mid-Semester Deliverable**

## Table of Contents
1.  Executive Summary
2.  Systems Request
3.  Project Work Plan
4.  Feasibility Analysis
    - Technical Feasibility
    - Economic Feasibility
    - Organizational Feasibility
5.  Requirements Definition Document
    - Functional Requirements
        - A. Functional Requirements for Booking Specialists
        - B. Functional Requirements Related to Customers (Handled by Booking Specialists)
    - Nonfunctional Requirements
6.  Set of Use Cases
    - Use Case Description: Conference Room Booking (CRB-001)
7.  Process Model (Data Flow Diagrams - DFDs)
    - Context Diagram (Level 0 DFD)
    - Level 0 DFD (System Diagram)
    - Level 1 DFD for Process 1.0: Receive Booking Request
    - Level 1 DFDs for Processes 2.0, 3.0, 4.0, and 5.0: (To be developed for Final Deliverable)
    - Data Stores
8.  Data Model (E-R Diagram)
9.  Appendix
    - Appendix: Interview Summary - Bruce Hunt, Hotel General Manager

---

## 1. Executive Summary

[**To be written last, after finalizing all other sections.**  This section should summarize the key aspects of your System Proposal Draft.  It should briefly cover:]

*   **Purpose of the System:**  What problem does the Cowboy Hotel Conference Room Booking System solve? What are its main goals?
*   **Key Requirements:** Briefly mention the core functional and non-functional requirements.
*   **Feasibility Assessment:** Summarize the findings of your technical, economic, and organizational feasibility analysis.  Is the project feasible?
*   **Project Plan:**  Mention the project phases and timeline.  Are you on track?
*   **Process and Data Models:**  Indicate that process models (DFDs) and a data model (E-R Diagram) have been developed to visualize and define the system. Acknowledge any sections that are still under development (like Level 1 DFDs for all processes).
*   **Overall Readiness:**  Conclude by stating that the system proposal draft demonstrates a solid understanding of the project requirements and that the team is ready to move into the design phase.

[**Example Executive Summary (Replace with your own, more detailed version):**]

> This System Proposal Draft outlines a plan for the development of a new Conference Room Booking System for the Cowboy Hotel. The current manual booking process is inefficient and error-prone, leading to lost revenue and operational challenges.  The proposed system aims to automate and streamline conference room bookings, improve efficiency, and enhance revenue potential.
>
> Key functional requirements include managing conference room bookings, processing payments (tracking), handling room availability and scheduling, and generating reports for management.  Non-functional requirements emphasize operational compatibility, performance, and security.
>
> A feasibility analysis indicates that the project is technically feasible using readily available technologies, economically viable with a strong projected return on investment, and organizationally aligned with the hotel's needs and strategic goals.
>
> A project work plan has been developed outlining the project phases and timeline.  The project is currently in the Analysis phase.
>
> Preliminary process models (Data Flow Diagrams) and a data model (Entity-Relationship Diagram) have been created to visualize the system's processes and data structure. Level 1 DFDs for all Level 0 processes are under development for the final deliverable.
>
> This draft system proposal demonstrates a comprehensive understanding of the project requirements and a well-defined plan for system development.  The project team is prepared to proceed to the Design phase based on the progress made and documented in this proposal.


## 2. Systems Request

**System Request - Cowboy Hotel Conference Room Booking System**

**Project Sponsor:**
Jaime Bradson, Hotel Manager, Cowboy Hotel

**Business Need:**
This project's goal is to design and implement an automated and user-friendly system for managing conference room bookings and event planning at the Cowboy Hotel. The current manual process is inefficient, error-prone (e.g., double-booking), and limits revenue potential due to underutilized conference facilities. A dedicated system is required to streamline operations and enable effective marketing of the newly constructed conference rooms.

**Business Requirements:**

1.  A standalone system for conference room bookings, separate from the existing hotel room booking software.
2.  Features to prevent double-booking and ensure real-time availability updates.
3.  User-friendly interface for efficient data entry, accessible by multiple staff members (Josephine Leon and future hires).
4.  Reporting capabilities for tracking bookings, revenue, customer preferences and possibly others (t.b.d)
5.  Compatibility with existing hardware (Windows 11 and Office Professional 2014) and future scalability.
6.  Remote access for Jaime Bradson from his office.

**Business Value:**

*   **Tangible Benefits:**
    *   **Revenue Growth:** Projected annual revenue increase of 140,000 from conference room bookings.
    *   **Cost Savings:** Reduced labor costs and errors (e.g., minimized double-booking penalties).
*   **Intangible Benefits:**
    *   Improved customer satisfaction due to seamless booking experiences, reduced customer frustration.
    *   Enhanced staff efficiency and reduced administrative workload.
    *   Better data management for strategic decision-making.

**Special Issues or Constraints:**

*   Development budget capped at $56,000.
*   Existing hardware limitations (only one computer in use; two additional computers planned).
*   Urgency due to current manual processes causing operational inefficiencies.
*   Emphasis on simplicity and ease of use for staff with minimal technical training.

## 3. Project Work Plan

**Project Work Plan**

| Task ID | Task Name                          | Phase          | Start Date | Finish Date | Duration | Dependencies | Staff Assigned   | Actual Completion Date |
|---------|------------------------------------|----------------|------------|-------------|----------|--------------|------------------|------------------------|
| P1      | Define Project Scope & Objectives  | Planning       | 1/20/2025  | 1/27/2025   | 7 days   | None         | Team Member 1    | 1/27/2025              |
| P2      | Select Development Methodology    | Planning       | 1/27/2025  | 2/3/2025    | 7 days   | P1           | Team Member 2    | 2/3/2025               |
| P3      | Create Initial Project Timeline     | Planning       | 2/3/2025   | 2/10/2025   | 7 days   | P2           | Team Member 1    | 2/10/2025              |
| A1      | Conduct Stakeholder Interviews     | Analysis       | 2/10/2025  | 2/17/2025   | 7 days   | P3           | Team Member 2    | 2/17/2025              |
| A2      | Document Functional Requirements   | Analysis       | 2/17/2025  | 2/24/2025   | 7 days   | A1           | Team Member 1    | 2/24/2025              |
| A3      | Develop Use Case Diagrams          | Analysis       | 2/24/2025  | 3/3/2025    | 7 days   | A2           | Team Member 2    | In Progress          |
| A4      | Create Process Models (Data Flow)  | Analysis       | 3/3/2025   | 3/10/2025   | 7 days   | A3           | Team Member 1    |                        |
| A5      | Finalize Data Models (ER Diagrams) | Analysis       | 3/10/2025  | 3/17/2025   | 7 days   | A4           | Team Member 2    |                        |
| D1      | Design System Architecture         | Design         | 3/24/2025  | 3/31/2025   | 7 days   | A5           | Team Member 1    |                        |
| D2      | Develop UI Wireframes & Mockups    | Design         | 3/31/2025  | 4/7/2025    | 7 days   | D1           | Team Member 2    |                        |
| D3      | Design Database Schema             | Design         | 4/7/2025   | 4/14/2025   | 7 days   | D1           | Team Member 1    |                        |
| D4      | Create Program Design Specifications| Design         | 4/14/2025  | 4/21/2025   | 7 days   | D2, D3       | Team Member 2    |                        |
| I1      | Develop System Prototype           | Implementation | 4/21/2025  | 5/5/2025    | 14 days  | D4           | Team Member 1    |                        |
| I2      | Conduct User Acceptance Testing (UAT)| Implementation | 5/5/2025   | 5/12/2025   | 7 days   | I1           | Team Member 2    |                        |
| I3      | Deploy System to Production Environment| Implementation | 5/12/2025  | 5/19/2025   | 7 days   | I2           | Team Member 1    |                        |
| I4      | Prepare Final Project Documentation| Implementation | 5/19/2025  | 5/26/2025   | 7 days   | I3           | Team Member 2    |                        |

## 4. Feasibility Analysis

**Cost-Benefit Analysis for Cowboy Hotel Conference Room Booking System**

| Category                     | Year 1      | Year 2      | Year 3      | Total       |
|------------------------------|-------------|-------------|-------------|-------------|
| **Benefits**                 |             |             |             |             |
| Increased Revenue            | $100,000    | $140,000    | $180,000    | $420,000    |
| Cost Savings (Labor/Errors)  | $15,000     | $20,000     | $25,000     | $60,000     |
| **Total Benefits**           | **$115,000**| **$160,000**| **$205,000**| **$480,000**|
| **Development Costs**        |             |             |             |             |
| Software Development         | $56,000     | —           | —           | $56,000     |
| **Operational Costs**        |             |             |             |             |
| Hardware (2 Computers)       | $3,000      | —           | —           | $3,000      |
| Software Licenses/Maintenance| $5,000      | $5,000      | $5,000      | $15,000     |
| Training & Support           | $2,000      | $1,000      | $1,000      | $4,000      |
| **Total Operational Costs**  | **$10,000** | **$6,000**  | **$6,000**  | **$22,000** |
| **Total Costs**              | **$66,000** | **$6,000**  | **$6,000**  | **$78,000** |
| **Net Benefits (Benefits - Costs)** | **$49,000** | **$154,000**| **$199,000**| **$402,000**|
| **Cumulative Net Cash Flow** | **$49,000** | **$203,000**| **$402,000**| —           |

### Technical Feasibility

The proposed Cowboy Hotel Conference Room Booking System appears to be technically feasible. The system requirements specify compatibility with existing and future hardware (Windows 11 and Office Professional 2014), suggesting the use of standard and readily available technologies.  The system is intended to be a standalone application, separate from the existing hotel room booking software, which simplifies integration complexities.  While there is a need to ensure a user-friendly interface accessible to multiple staff members with varying technical skills, this is a common challenge in software development and can be addressed through careful design and user testing.  The constraint emphasizing simplicity and ease of use further reinforces the focus on a technically straightforward and manageable solution for the hotel staff.  The planned addition of two computers addresses the current hardware limitations, making the deployment of a new system technically viable.

### Economic Feasibility

The project demonstrates strong economic feasibility as evidenced by the provided cost-benefit analysis.  The analysis projects significant net benefits over the first three years of operation, totaling $402,000, with a positive cumulative cash flow.  The system is expected to generate substantial increased revenue from conference room bookings ($420,000 over three years) and cost savings through reduced labor and booking errors ($60,000 over three years).  The total development cost is estimated at $56,000, which aligns with the development budget cap.  Operational costs, including hardware, software licenses, and training, are relatively low compared to the projected benefits.  The clear return on investment indicated by the positive net benefits and cash flow strongly supports the economic viability of this project, making it a worthwhile investment for the Cowboy Hotel.

### Organizational Feasibility

The Cowboy Hotel Conference Room Booking System also exhibits strong organizational feasibility.  The project is sponsored by Jaime Bradson, the Hotel Manager, indicating clear management support and alignment with the hotel's strategic goals.  The stated business need directly addresses operational inefficiencies and revenue limitations within the hotel's conference room booking process, highlighting a clear organizational problem to be solved.  The system requirements consider the needs of hotel staff by emphasizing a user-friendly interface and ease of use, which is crucial for successful adoption and minimizes resistance to change.  Furthermore, the urgency stemming from current manual processes causing inefficiencies underscores the organizational readiness and need for a swift implementation of this automated system. The focus on simplicity and minimal technical training for staff also aligns with the organizational context and ensures a smooth transition and integration of the new system into hotel operations.

## 5. Requirements Definition Document

**Requirements Definition Document**

### Functional Requirements

#### A. Functional Requirements for Booking Specialists:

1.  **Manage Conference Room Bookings:**
    1.1.  The system shall allow booking specialists to create, modify, and cancel conference room reservations, including specifying dates, times, room selection, and customer details.
    1.2.  The system shall prevent double-booking by automatically checking room availability for the requested date and time before confirming a reservation.
    1.3.  The system shall track booking statuses, including "Pending," "Confirmed," "Canceled," and "Completed."

2.  **Process Payments:**
    2.1.  The system shall calculate the total rental fee for a booking based on the selected room type, duration of booking, and any additional services requested (e.g., catering, AV equipment).
    2.2.  The system shall enable booking specialists to apply predefined discounts, such as percentage-based discounts for multi-day bookings or fixed amount discounts for special events.
    2.3.  The system shall record and update payment status for each booking, including statuses like "Pending Payment," "Paid," and "Refunded."
    2.4.  The system shall allow booking specialists to record details of payment transactions processed outside the system (e.g., payments made directly via the hotel's existing payment system).

3.  **Room Availability & Scheduling:**
    3.1.  The system shall allow booking specialists to search for available conference rooms based on criteria including date, time, capacity (number of attendees), and room features (e.g., projector, whiteboard).
    3.2.  The system shall automatically update the Room Availability Database in real-time whenever a new reservation is confirmed or when a cancellation is processed.
    3.3.  If a customer's preferred room is unavailable for the requested time, the system shall suggest alternative room options that meet the customer's criteria, if available.

4.  **Generate Reports & Manage Booking Data:**
    4.1.  The system shall generate weekly and monthly booking reports for management, summarizing key metrics such as:
        *   Total number of bookings
        *   Revenue generated from bookings
        *   Room utilization rates (percentage of time each room is booked)
    4.2.  The system shall allow hotel managers to review room usage trends and financial summaries through interactive dashboards or reports, enabling them to identify peak booking times, popular rooms, and revenue patterns.

#### B. Functional Requirements Related to Customers (Handled by Booking Specialists):

5.  **View Available Conference Rooms (for Customers):**
    5.1.  The system shall enable booking specialists to retrieve and provide customers with comprehensive details on available rooms, including:
        *   Room capacity
        *   Standard room amenities (e.g., included equipment)
        *   Optional amenities (e.g., catering, AV equipment rental) and associated costs
        *   Hourly and daily pricing

6.  **Manage Existing Bookings (for Customers):**
    6.1.  The system shall enable booking specialists to modify existing reservations at the customer's request, including changes to date, time, room, and services.
    6.2.  The system shall enable booking specialists to cancel reservations at the customer's request, following hotel cancellation policies.
    6.3.  The system shall maintain a history of all past bookings, allowing specialists to quickly access and provide customers with details of their previous bookings.
    6.4.  The system shall allow booking specialists to add additional services (e.g., catering, AV equipment) to an existing booking at the customer's request.

### Nonfunctional Requirements

1.  **Operational Requirements:**
    1.1.  **Platform Compatibility:** The system shall be compatible with the Windows 11 operating system and Microsoft Office Professional 2019 suite.
    1.2.  **Access Control:** The system shall be accessible only from computers designated for hotel staff use within the hotel premises to prevent unauthorized external access.

2.  **Performance Requirements:**
    2.1.  **Room Availability Query Response Time:** The system shall process and return results for room availability queries from booking specialists within 2 seconds under normal operating conditions.
    2.2.  **Concurrent User Support:** The system shall reliably support up to 4 concurrent booking specialists actively using the system during peak booking hours without significant performance degradation.

3.  **Security Requirements:**
    3.1.  **User Authentication:** The system shall require unique username and password-based login credentials for each booking specialist to access the system.
    3.2.  **Data Encryption:** The system shall store all sensitive customer data (including names, contact information, and organizational affiliations) securely using industry-standard encryption methods, both in transit and at rest.
    3.3.  **Audit Logging:** The system shall maintain a comprehensive audit log of all booking modifications, cancellations, payment records, and staff login/logout activities, including timestamps and user IDs.

4.  **Cultural and Political Requirements:**
    4.1.  **Time Zone Support:** The system shall support handling bookings and displaying time information in multiple time zones to accommodate customers booking from different geographical regions.
    4.2.  **Policy Alignment:** The system's configuration for room descriptions, pricing rules, discount application, and cancellation policies shall be easily customizable by hotel management to ensure alignment with evolving hotel business policies and strategies.

## 6. Set of Use Cases

**Set of Use Cases**

**Use Case Description: Conference Room Booking**

**Use Case Name:** Conference Room Booking
**ID:** CRB-001
**Importance Level:** High
**Primary Actor:** Customer
**Short Description:** This use case describes how a customer selects and reserves a conference room through the Cowboy Hotel Conference Room Booking System.
**Trigger:** Customer calls to book a conference room or submits a booking request online.
**Type:** External / Temporal

**Preconditions:**
* The Conference Room Booking System is operational.
* Conference room availability data is up-to-date.
* Booking specialist is logged into the system.

**Postconditions:**
* A conference room reservation is successfully recorded in the system.
* Customer receives a booking confirmation with reservation details.
* Room availability is updated in the system to reflect the new booking.

**Major Inputs:**

| Description             | Source           |
|-------------------------|------------------|
| Customer name           | Customer         |
| Desired room            | Customer         |
| Desired date and time   | Customer         |
| Contact information     | Customer         |
| Available rooms         | Booking System   |
| Existing reservations   | Reservation database |

**Major Outputs:**

| Description            | Destination       |
|------------------------|-------------------|
| Confirmed reservation  | Customer          |
| Reserved time slot     | Booking System    |
| Confirmation email     | Customer          |
| Catering order         | Hotel Manager     |
| Booking report         | Booking Specialist |

**Major Steps Performed:**

1.  **Get customer's name.** Booking specialist asks for and records the customer's name. Verify if customer exists in the system by searching the customer database.
    *   *Information for Steps:* Customer name, Customer database

2.  **If new customer, get contact information and create new customer record.** If the customer is new, booking specialist collects contact information (phone, email, organization if applicable) and creates a new customer record in the system.
    *   *Information for Steps:* Contact information, Organization details, New customer record

3.  **Get desired room, date, and time slot.** Booking specialist asks the customer for their preferred conference room, date, and time slot for the booking and records this information.
    *   *Information for Steps:* Desired room, Desired date, Desired time slot

4.  **Check room availability for requested time slot in Reservation database.** The system checks the Reservation database to determine if the requested room is available for the specified date and time.
    *   *Information for Steps:* Available rooms, Existing reservations, Room capacity

5.  **If room is available, create reservation in system. If unavailable, suggest alternatives.**
    *   If the room is available, the booking specialist proceeds to create a new reservation record in the system with the collected information.
    *   If the room is unavailable, the system prompts the booking specialist to suggest alternative rooms or times to the customer.
    *   *Information for Steps:* Room availability, Alternative slots, Confirmation details

6.  **Record catering requests if applicable and flag for manager approval.** Booking specialist asks the customer if they require catering services. If yes, the specialist records the catering requests in the system and flags the reservation for manager approval of catering arrangements.
    *   *Information for Steps:* Catering options, Catering requests, Manager approval flag

7.  **Booking specialist reviews and confirms reservation.** Booking specialist reviews all reservation details with the customer and confirms the booking in the system.
    *   *Information for Steps:* Reservation details, Specialist approval, Booking system

8.  **Send confirmation to customer with reservation details.** The system automatically generates and sends a booking confirmation email to the customer with all reservation details, including room, date, time, services, and confirmation ID.
    *   *Information for Steps:* Confirmation email, Reservation ID, Customer details

**(Note:  Alternative flows and exception handling, such as handling room unavailability, booking modifications, cancellations, and system errors, will be documented in the final version of the use case description to ensure comprehensive coverage.)**

## 7. Process Model (Data Flow Diagrams - DFDs)

**Process Model (Data Flow Diagrams - DFDs)**

### Context Diagram (Level 0 DFD)