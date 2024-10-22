"use client";
import axios from "axios";
import { useSession } from "next-auth/react";

export default function Profile() {
  const { data: session } = useSession();

  const onSubmitLogin = (data) => {
    setLoadingSpin(true);
    const dataReqLogin = {
      email: data.userName,
      password: data.password,
    };
    LoginApi(dataReqLogin)
      .then((res) => {
        setCookie("accountId", res.data.result.accountId, { expires: 7 });
        setCookie("email", res.data.result.accountEmail, { expires: 7 });
        setCookie("accountName", res.data.result.accountName, { expires: 7 });
        setCookie("jwt_token", res.data.result.token, { expires: 7 });
        StatusAlertService.showSuccess("Đăng nhập thành công!");
        if (messageUnauthorized === "") {
          router.push(UrlPath.home.url);
        } else {
          router.back();
        }
      })
      .catch((err) => {
        StatusAlertService.showError(err.response.data.Detail);
      })
      .finally(() => {
        setLoadingSpin(false);
      });
  };

  const getProfile = async () => {
    console.log("ádasđ", session);
    const res = await axios.get(`https://localhost:44302/api/Account/profile`, {
      headers: {
        Authorization: `Bearer ${session.accessToken}`,
      },
    });
    console.log(res.data);
  };

  return (
    <div>
      <button onClick={getProfile}>Lấy thông tin người dùng</button>
    </div>
  );
}
