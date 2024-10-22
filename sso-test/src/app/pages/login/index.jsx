"use client";
import { BASE_URL } from "@/app/api/request";
import Profile from "@/app/components/Profile";
import { SessionProvider, signIn, signOut, useSession } from "next-auth/react";
export default function LoginPage() {
  const { data: session } = useSession();

  if (session) {
    return (
      <>
        <p>Đăng nhập thành công với Google</p>
        <Profile></Profile>
        <button onClick={() => signOut()}>Đăng xuất</button>
      </>
    );
  }
  const handleLoginSso = () => {
    axios
      .get(`${BASE_URL}sso/google}`)
      .then((res) => {
        //setCommentData(res.data.result.comments);
      })
      .catch((err) => {
        //StatusAlertService.showError(err.response.data.Detail);
      });
  };
  return (
    <SessionProvider>
      <p>Bạn chưa đăng nhập</p>
      <button onClick={() => handleLoginSso()}>Đăng nhập với Google</button>
    </SessionProvider>
  );
}
