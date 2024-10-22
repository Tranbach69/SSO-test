"use client";
import { SessionProvider } from "next-auth/react";
import LoginPage from "./pages/login";

export default function Home() {
  return (
    <SessionProvider>
      {/* <SessionProvider>{children}</SessionProvider> */}
      <LoginPage></LoginPage>
    </SessionProvider>
  );
}
