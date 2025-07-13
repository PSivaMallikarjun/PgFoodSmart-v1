Here is the **FRS (Functional Requirements Specification)** document for your **FoodWise PG** fullstack project:

---

# 📘 Functional Requirements Specification (FRS)

**Project Title**: FoodWise PG – Smart Meal Management System
**Prepared by**: P Siva Mallikarjun
**Date**: 13-July-2025

---

## 🔖 1. Introduction

**FoodWise PG** is a smart meal management platform designed for Paying Guest (PG) accommodations. It provides PG Owners (Admins) the ability to manage residents, predict daily meal demand using AI, and track meal confirmations in real-time through web and mobile platforms.

---

## 📌 2. Actors & Roles

| Actor              | Role Description                                               |
| ------------------ | -------------------------------------------------------------- |
| PG Owner (Admin)   | Manages PG, adds residents, monitors dashboard                 |
| PG Resident (User) | Confirms daily meals, views history, uses mobile/web interface |

---

## ✅ 3. Functional Requirements

### A. Authentication & Role Management

* FR1: The system shall allow Admins and Users to log in via Firebase Authentication.
* FR2: The system shall distinguish users by role (Admin/User).
* FR3: The system shall restrict access to Admin Dashboard to only Admins.

### B. Admin Dashboard (React.js)

* FR4: Admin shall be able to register a PG property.
* FR5: Admin shall be able to pre-register Users (residents) with basic details (name, email, room no.).
* FR6: Admin shall be able to view real-time meal confirmations.
* FR7: Admin shall be able to view predicted meal demand for the day/week.
* FR8: Admin shall receive alerts when resident response deadline is missed.
* FR9: Admin can update resident records and status.

### C. User (Mobile - Kotlin)

* FR10: User shall receive daily meal notification asking for confirmation (Yes/No).
* FR11: User shall be able to view confirmation status and past submissions.
* FR12: User shall not be able to register without Admin invitation.
* FR13: User shall have the option to set default meal preferences.

### D. AI Meal Prediction Engine (Optional Python microservice or integrated logic)

* FR14: System shall predict daily meal demand using historical data.
* FR15: Prediction shall be displayed in Admin Dashboard.
* FR16: AI engine shall improve predictions over time via learning feedback loop.

### E. Data Management

* FR17: All user data, confirmations, and analytics shall be stored in Firebase Firestore.
* FR18: The system shall securely manage Firestore rules to prevent unauthorized access.

### F. Deployment & Accessibility

* FR19: The web dashboard shall be PWA enabled.
* FR20: The mobile app shall be installable on Android.
* FR21: The system shall support English and Hindi languages.
* FR22: Dark/light theme toggle shall be available in web and mobile.

---

## 📈 4. Non-Functional Requirements (Summary)

| NFR Code | Description                                      |
| -------- | ------------------------------------------------ |
| NFR1     | Performance: Web app loads within 3 seconds      |
| NFR2     | Security: Firebase Auth with role-based control  |
| NFR3     | Availability: 99.9% uptime with Firebase Hosting |
| NFR4     | Scalability: Support up to 500 PG users          |
| NFR5     | Maintainability: Modular code with documentation |

---

## 📋 5. Assumptions

* Internet is available to access Firebase services.
* Admins will have access to the web dashboard (desktop/laptop).
* Residents will primarily use mobile (Kotlin-based Android app).

---

## 📅 6. Future Scope

* QR-based check-in for meals
* Integration with payment gateway for food cost billing
* Multilingual expansion beyond English/Hindi
* Admin analytics for inventory planning

---

