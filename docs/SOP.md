Here are both the **BRS (Business Requirement Specification)** and **SRS (System Requirement Specification)** documents for your **FoodWise PG** project:

---

## 📘 Business Requirement Specification (BRS)

### 📌 Project Title:

**FoodWise PG – Smart Meal Management System**

### 🎯 Purpose:

To simplify and digitize daily meal tracking and prediction in Paying Guest (PG) accommodations by building an intelligent system accessible via web and mobile platforms.

---

### 📈 Business Goals:

* Automate meal confirmations from residents
* Predict daily meal demand using AI to reduce food waste
* Provide PG owners with a real-time meal planning dashboard
* Simplify user registration and meal tracking via mobile
* Ensure controlled access via role-based authentication

---

### 🧑‍💼 Target Users:

| User Type   | Purpose                        |
| ----------- | ------------------------------ |
| PG Owner    | Manage PG and view reports     |
| PG Resident | Confirm meals and view history |

---

### 💡 Key Features:

* Admin can pre-register PG residents
* Residents can confirm meal attendance daily
* Real-time dashboard for daily status
* AI-driven meal demand prediction
* Firebase-based authentication and hosting
* PWA support for desktop/mobile access
* Kotlin Android app for residents
* Role-based permissions for security

---

### 💰 Business Benefits:

* Reduces food wastage and cost
* Digitizes manual registers/confirmations
* Enhances resident satisfaction with reminders
* Improves inventory and vendor management via predictions
* Multi-language and theme support for wider usability

---

---

## 📗 System Requirement Specification (SRS)

### 📌 1. Introduction

#### 1.1 System Overview

FoodWise PG is a fullstack solution that allows PG Owners to manage meal planning, track confirmations, and leverage AI to predict food demand. Built with Flutter (mobile), React.js (admin dashboard), and .NET Web API (optional backend expansion), hosted via Firebase.

---

### ⚙️ 2. System Features

| ID  | Feature                         | Description                                              |
| --- | ------------------------------- | -------------------------------------------------------- |
| SF1 | User Registration               | Admin invites residents; residents cannot self-register  |
| SF2 | Daily Meal Confirmation         | Residents confirm meals via mobile app                   |
| SF3 | Real-Time Dashboard             | Admin views meal confirmations instantly                 |
| SF4 | AI Meal Prediction              | System shows daily/weekly predictions based on history   |
| SF5 | Role-Based Access               | Admin and user dashboards based on roles                 |
| SF6 | Notification System             | Push/email notifications for meal confirmation reminders |
| SF7 | Multi-language and Theme Toggle | Interface in English/Hindi; Light/Dark mode              |
| SF8 | Offline Support                 | Web dashboard is PWA-enabled with offline caching        |

---

### 🧩 3. System Architecture

* **Frontend Web (React.js):** Admin UI with dashboard and analytics
* **Mobile App (Kotlin or Flutter):** Resident UI for confirmations
* **Backend (Optional .NET Web API):** Business logic layer for scalability
* **Firebase:** Auth, Firestore, Hosting, Cloud Functions
* **AI Model (Python or integrated service):** Meal demand forecasting

---

### 🔐 4. Security Requirements

* Firebase Auth for secure role-based login
* Firestore access rules for Admin/User separation
* All data encrypted at rest and in transit

---

### 📱 5. User Interface Requirements

#### Admin Web Interface:

* Login
* Dashboard with charts
* Resident management
* AI predictions
* Settings (theme, language)

#### User Mobile App:

* Login
* Confirm meals (Yes/No)
* Meal history
* Notifications

---

### 📦 6. Data Requirements

* Resident Profile: Name, Email, Room No., UID
* Confirmation Record: Date, Status, Timestamp
* PG Profile: Name, Location, Owner UID
* Prediction Dataset: Date, Predicted Count, Confidence %

---

### ⚡ 7. Performance Requirements

| Requirement | Value                       |
| ----------- | --------------------------- |
| Load time   | < 3 seconds                 |
| Response    | < 500ms for dashboard calls |
| Uptime      | 99.9% via Firebase Hosting  |

---

### 🛠️ 8. Tools & Technologies

| Area           | Technology              |
| -------------- | ----------------------- |
| Web Frontend   | React.js                |
| Mobile App     | Kotlin or Flutter       |
| Backend API    | .NET Web API (optional) |
| Database       | Firebase Firestore      |
| Auth & Hosting | Firebase                |
| AI Integration | Python/Cloud Functions  |

---
