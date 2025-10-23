# Podcast Manager – Lab #3 (COMP306)

## 📌 Overview
This project is a **cloud‑native podcast management application** built with **ASP.NET Core MVC**.  
It integrates both **relational (SQL Server)** and **NoSQL (DynamoDB)** databases, and leverages **AWS services** such as Elastic Beanstalk, RDS, DynamoDB, S3, and IAM.

The system allows:
- Podcasters to create and manage podcasts and episodes.
- Listeners to subscribe, view, and comment on episodes.
- Administrators to oversee users and content.

---

## 🎯 Purpose
- Gain hands‑on experience with AWS cloud services.
- Understand ASP.NET Core MVC layered architecture.
- Learn how to integrate **SQL Server (structured data)** with **DynamoDB (unstructured data)**.
- Deploy and manage applications on **AWS Elastic Beanstalk**.

---

## 🏗️ System Architecture
- **Presentation Layer**: ASP.NET MVC views (UI for dashboard, episode forms, etc.).
- **Business Logic Layer**: Controllers and services (e.g., `EpisodeService` for CRUD).
- **Data Access Layer**:
  - EF Core repositories for SQL Server (RDS).
  - AWS SDK for DynamoDB (comments).
  - S3 for storing audio/video files.

---

## 🗄️ Database Design

### Relational Database (SQL Server – RDS)
- **Podcasts Table**
  - PodcastID (PK, int, auto-increment)
  - Title, Description
  - CreatorID (Guid)
  - CreatedDate

- **Episodes Table**
  - EpisodeID (PK, int, auto-increment)
  - PodcastID (FK)
  - Title, ReleaseDate, Duration (minutes)
  - PlayCount (number of viewers)
  - AudioFileURL (S3 link)

- **Users Table** (via ASP.NET Identity)
  - UserID (Guid, PK)
  - Username, Email
  - Role (enum: Podcaster, Listener, Admin)

- **Subscriptions Table**
  - SubscriptionID (PK, int)
  - UserID (FK), PodcastID (FK)
  - SubscribedDate

### DynamoDB (Unstructured Data)
- **Comments Table**
  - EpisodeID
  - PodcastID
  - CommentID (Guid)
  - UserID
  - Text
  - Timestamp

---

## ⚙️ Features

### Authentication
- User registration & login (stored in SQL Server via Identity).

### Podcast Management (Podcaster Role)
- Create, edit, delete podcasts and episodes.
- Upload audio/video files to S3.

### Episode Interaction (Listener Role)
- Browse/search episodes (by topic, host, release date).
- Add comments (stored in DynamoDB).
- Edit comments (within 24 hours, only by the author).
- Subscribe to podcasts.

### Analytics (Admin/Podcaster)
- View episode stats (views, play count).
- List most popular episodes.
- Generate basic reports.

### Admin Panel
- Manage users.
- Approve episodes.

---

## 🚀 Deployment
1. Store RDS credentials in **AWS Parameter Store**.
2. Deploy the app to **AWS Elastic Beanstalk**.
3. Use **AWS DynamoDB Console** to create and populate the Comments table.
4. Upload audio/video files to **AWS S3**.

---

## 📝 Notes
- Use **UTC timestamps** for consistency.
- Ensure **readability, maintainability, and efficiency** in code.
- Follow **ASP.NET Core MVC best practices**.
