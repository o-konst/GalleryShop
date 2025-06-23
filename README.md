# GalleryShop Playground Solution

This solution contains **three ** separate projects, each serving a specific role in the system architecture. It is built with **.NET 9**, uses **PostgreSQL** for data storage, and **AWS S3** for image hosting.

---

## 🖼️ 1. GalleryShop (Blazor Web App)

A full-featured Blazor Server application deployed as a Docker container on AWS EC2.

- 🧠 Built with **.NET 9**
- 🗄 Uses **PostgreSQL** for structured data
- ☁️ Uploads and retrieves all images from **AWS S3**
- 🔗 **Demo:** [https://new.coachlink.co.nz](https://new.coachlink.co.nz)

### 📸 Screenshots

![GalleryShop Screenshot 1](https://github.com/user-attachments/assets/f54b6611-f774-4992-9096-76981ca2e5bd)
![GalleryShop Screenshot 2](https://github.com/user-attachments/assets/5e9d30ea-a399-4393-bc7a-2b6c01c6372f)

---

## 🔧 2. GalleryShop API (Web API)

A RESTful backend API for the GalleryShop ecosystem, deployed as a Docker container on AWS EC2.

- 🧠 Built with **.NET 9**
- 🗄 Connects to **PostgreSQL** for persistent data
- ☁️ Handles image uploads to and downloads from **AWS S3**
- 📦 Provides endpoints for managing galleries, products, and user data

---

## 🌐 3. GalleryShop Blazor WASM (PWA)

A standalone Progressive Web App built with Blazor WebAssembly.

- 🧠 Built with **.NET 9**
- ✅ Deployed to **AWS S3**
- 🌍 Served through **AWS CloudFront**
- ☁️ Displays images fetched from **AWS S3**
- 🗄 Communicates with the API (which uses **PostgreSQL**)

🔗 **Demo:** [https://d5jc0mvmc13um.cloudfront.net/](https://d5jc0mvmc13um.cloudfront.net/)

### 📸 Screenshots

![WASM Screenshot 1](https://github.com/user-attachments/assets/67322b83-bc78-462a-8c13-dc6e74250ae0)
![WASM Screenshot 2](https://github.com/user-attachments/assets/d11a72d2-1322-461a-ac3e-67a82b7a3753)

---

## 📦 Deployment Summary

| Project                 | Technology      | Hosting                  | Delivery                 | Database      | Image Storage |
|------------------------|-----------------|---------------------------|---------------------------|---------------|----------------|
| **GalleryShop**        | Blazor Server (.NET 9)   | AWS EC2 + Docker          | Web App                   | PostgreSQL    | AWS S3         |
| **GalleryShop API**    | ASP.NET Core (.NET 9)    | AWS EC2 + Docker          | Web API                   | PostgreSQL    | AWS S3         |
| **Blazor WASM (PWA)**  | Blazor WASM (.NET 9)     | AWS S3 + AWS CloudFront   | Static Web App (PWA)      | via API       | AWS S3         |

---

## 📁 Folder Structure

```text
/solution-root
│
├── GalleryShop             # Blazor Server App
├── GalleryShop.Api         # ASP.NET Core Web API
└── GalleryShop.Wasm        # Blazor WebAssembly PWA
